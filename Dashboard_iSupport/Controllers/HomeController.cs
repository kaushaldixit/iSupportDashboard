using ClosedXML.Excel;
using Dashboard_iSupport.Models;
using Dashboard_iSupport.Repos;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.Mvc;
using X.PagedList;
using static Microsoft.AspNetCore.Razor.Language.TagHelperMetadata;

namespace Dashboard_iSupport.Controllers
{
    public class HomeController : Controller
    {
        private readonly iSupportRepository _context;
        public HomeController(iSupportRepository context)
        {
            _context = context;
        }

        public IActionResult Index(string searchString, int? page)
        {
            ViewData["CurrentFilter"] = searchString;

            var result = _context.GetAll();
            if (!String.IsNullOrEmpty(searchString))
            {
                result = (List<iSupportData>)result.
                    Where(s => s.Number.ToUpper().Contains(searchString.ToUpper())
                   || s.Application_Name.ToUpper().Contains(searchString.ToUpper()) 
                   || s.Assignee.ToUpper().Contains(searchString.ToUpper())
                   || s.Error_Type.ToUpper().Contains(searchString.ToUpper())).ToList();
            }
            return View(result.ToPagedList(page ?? 1, 8));
            
        }
        [HttpPost]
        public IActionResult ExporttoExcel()
        {
            var result = _context.GetAll().ToList();
            using (XLWorkbook xl = new XLWorkbook())
            {
                object value = xl.Worksheets.Add(Models.Common.ToDataTable(result.ToList()));

                using (MemoryStream mstream = new MemoryStream())
                {
                    xl.SaveAs(mstream);
                    return File(mstream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "iSupportData.xlsx");
                }
            }
            
        }

        public IActionResult DetailsByTicketNo(string Number)
        {
            var result = _context.GetDataByTicket(Number);
            return View(result);
        }
        public IActionResult CreateTicket()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult CreateTicket(iSupportData model)
        {
           
            if (ModelState.IsValid)
            {
                string ticket = _context.CreateTicket(model);
                if (ticket != null)
                {
                    ModelState.Clear();
                    ViewBag.ticket = "Data saved";
                    return RedirectToAction("Index");

                }
            }
            return View();
        }

        public IActionResult Edit(string Number)
        {
            var result = _context.GetDataByTicket(Number);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(iSupportData model)
        {
            if(ModelState.IsValid)
            {
                _context.Update(model.Number, model);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(string Number)
        {
            _context.Delete(Number);
            return RedirectToAction("Index");
        }

        public IActionResult Dropdown()
        {
            List<ApplicationName> appName = new List<ApplicationName>();
            appName = _context.GetAllApp();
            appName.Insert(0, new ApplicationName { Id = 0, Application = "select" });
            ViewBag.listOfApplication = appName;

            return View();

        }

    }
}

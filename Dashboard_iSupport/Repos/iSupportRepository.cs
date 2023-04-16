using Dashboard_iSupport.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Dashboard_iSupport.Repos
{
    public class iSupportRepository
    {
        private readonly iSupportDbContext _context;
        public iSupportRepository(iSupportDbContext context)
        {
            _context= context;
        }

       
        public List<iSupportData> GetAll()
        {
            var result = _context.ISupportData.ToList();
            return result;
        }
        public iSupportData GetDataByTicket(string ticketNo)
        {
            var result = _context.ISupportData.Where(x => x.Number == ticketNo).FirstOrDefault();
            return result;
        }
        public string CreateTicket(iSupportData data)
        {
           _context.ISupportData.Add(data);
            _context.SaveChanges();
            return data.Number;

        }

        public bool Delete(string ticketNo)
        {
            var result = _context.ISupportData.FirstOrDefault(x => x.Number == ticketNo);
            if(result!=null)
            {
                _context.ISupportData.Remove(result);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update(string ticketNo, iSupportData model)
        {
            var result = _context.ISupportData.FirstOrDefault(x => x.Number == ticketNo);
            if(result!=null)
            {
                result.Number = model.Number;
                result.Status_Label = model.Status_Label;
                result.Priority = model.Priority;
                result.Date_Created = model.Date_Created;
                result.Date_Closed = model.Date_Closed;
                result.Assignee = model.Assignee;
                result.Time_Open__Min_ = model.Time_Open__Min_;
                result.TAT = model.TAT;
                result.Missing_Ticket = model.Missing_Ticket;
                result.Application_Name = model.Application_Name;
                result.Sub_Categorization_of_Error = model.Sub_Categorization_of_Error;
                result.Count_of_Errors = model.Count_of_Errors;
                result.Reason_for_Escalation_to_the_SME = model.Reason_for_Escalation_to_the_SME;
                result.Actual_Person_Handling_the_ticket = model.Actual_Person_Handling_the_ticket;
                result.Error_Type = model.Error_Type;
            }
            _context.SaveChanges();
            return true;
        }

        public List<ApplicationName> GetAllApp()
        {
            var result = _context.ApplicationName.ToList();
            return result;
        }
        public List<SubCategory> GetAllCategory(int subcategoryId)
        {
            var result = _context.SubCategories.Where(x => x.Id == subcategoryId).ToList();
            return result;
        }

    }
}

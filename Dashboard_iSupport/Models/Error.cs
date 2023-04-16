using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Dashboard_iSupport.Models
{
    public partial class Error
    {
        [Key]
        public int Eid { get; set; }
        public string ErrorType { get; set; }
        public int? Sid { get; set; }

        public virtual SubCategory SidNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Dashboard_iSupport.Models
{
    public partial class SubCategory
    {
        public SubCategory()
        {
            Errors = new HashSet<Error>();
        }

        [Key]
        public int Sid { get; set; }
        public string SubCategory1 { get; set; }
        public int? Id { get; set; }

        public virtual ApplicationName IdNavigation { get; set; }
        public virtual ICollection<Error> Errors { get; set; }
    }
}

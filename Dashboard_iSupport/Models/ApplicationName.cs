using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard_iSupport.Models
{
    [Table("ApplicationName",Schema = "dbo")]
    public class ApplicationName
    {
        public ApplicationName()
        {
            SubCategories = new HashSet<SubCategory>();
        }
        [Key]
        public int Id { get; set; }
        public string Application { get; set; }

        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}

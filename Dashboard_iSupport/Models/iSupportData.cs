using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard_iSupport.Models
{
    public class iSupportData
    {
        [Key]
        public string Number { get; set; }
        public string Status_Label { get; set; }
        public string Priority { get; set; }
        [Required]
        public DateTime Date_Created { get; set; }
        
        public DateTime Date_Closed { get; set; }
        public string Assignee { get; set; }
        public double Time_Open__Min_ { get; set; }
        public double TAT { get; set; }
        public string Missing_Ticket { get; set; }
        public string Application_Name { get; set; }
        public string Sub_Categorization_of_Error { get; set; }
        public double Count_of_Errors { get; set; }
        public string Reason_for_Escalation_to_the_SME { get; set; }
        public string Actual_Person_Handling_the_ticket { get; set; }
        public string Error_Type { get; set; }
    }
}

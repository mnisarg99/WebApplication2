using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Project
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Company Name")]
        public string CustomerName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Project Name")]
        public string ProjectName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Select Project ID")]
        public string ProjectId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:mm/dd/yyyy}")]
        public string StartDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:mm/dd/yyyy}")]
        public string EndDate { get; set; }
        [Required]
        public string ProjectStatus { get; set; }
        [Required]
        public string LocationGroup { get; set; }
        [Required]
        public string PayrollState { get; set; }
        [Required]
        public string SalesPerson { get; set; }
        [Required]
        public string ProjectCategory { get; set; }
        [Required]
        public string ProjectType { get; set; }
        [Required]
        public string SubDomain { get; set; }
        [Required]
        public string TimesheetRepresentative { get; set; }
        [Required]
        public string ClientInvoiceGroup { get; set; }
        [Required]
        public string TimesheetType { get; set; }
        [Required]
        public string IsVmsTimesheet { get; set; }
        [Required]
        public string PracticeType { get; set; }
        [Required]
        public string Recruiter { get; set; }
    }
}
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
        public string StartDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public string EndDate { get; set; }
        [Required]
        public int ProjectStatus { get; set; }
        [Required]
        public int LocationGroup { get; set; }
        [Required]
        public int PayrollState { get; set; }
        [Required]
        public int SalesPerson { get; set; }
        [Required]
        public int ProjectCategory { get; set; }
        [Required]
        public int ProjectType { get; set; }
        [Required]
        public int SubDomain { get; set; }
        [Required]
        public int TimesheetRepresentative { get; set; }
        [Required]
        public int ClientInvoiceGroup { get; set; }
        [Required]
        public int TimesheetType { get; set; }
        [Required]
        public int IsVmsTimesheet { get; set; }
        [Required]
        public int PracticeType { get; set; }
        [Required]
        public int Recruiter { get; set; }
    }
}
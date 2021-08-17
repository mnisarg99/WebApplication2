using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Project
    {
        public string CustomerName { get; set; }
        public int ProjectName { get; set; }

        public int ProjectId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int ProjectStatus { get; set; }

        public int LocationGroup { get; set; }

        public string PayrollState { get; set; }

        public int SalesPerson { get; set; }

        public string ProjectCategory { get; set; }

        public string ProjectType { get; set; }

        public int SubDomain { get; set; }

        public int TimesheetRepresentative { get; set; }
        public int ClientInvoiceGroup { get; set; }
        public int TimesheetType { get; set; }
        public int IsVmsTimesheet { get; set; }
        public int PracticeType { get; set; }
        public int Recruiter { get; set; }
    }
}
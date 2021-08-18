using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class ProjectAddEditViewModel
    {
        public Project Project { get; set; }
        public List<AppRefData> ProjectSta { get; set; }
        public List<AppRefData> ProjectCategories { get; set; }
        public List<AppRefData> ProjectTypes { get; set; }
        public List<AppRefData> ClientInvoiceGroups { get; set; }
        public List<AppRefData> TimesheetTypes { get; set; }
        public List<AppRefData> PracticeTypes { get; set; }
        public List<Projlist> Recruiters { get; set; }
        public List<Projlist> Locationgroups { get; set; }
        public List<Projlist> TimesheetRepresentatives { get; set; }
        public List<Projlist> SubDomains { get; set; }
        public List<Projlist> SalesPersons { get; set; }
        public List<Projlist> PayrollStates { get; set; }
        public object CustomerName { get; set; }
        public object ProjectName { get; set; }
        public object ProjectId { get; set; }
        

    }
}
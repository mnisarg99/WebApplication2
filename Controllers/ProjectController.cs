using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication2.Repository;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult Index()
        {
            common objRepo = new common();

            var appRefStatus = objRepo.GetAppRefData(1800);
            var appRefCategory = objRepo.GetAppRefData(19491);
            var appRefType = objRepo.GetAppRefData(4650);
            var appRefInvoice = objRepo.GetAppRefData(10300);
            var appRefSheetType = objRepo.GetAppRefData(13120);
            var appRefPracticeType = objRepo.GetAppRefData(15760);
            var Rec = objRepo.GetRecr();
            var location = objRepo.GetLocation();
            var timesheet = objRepo.GetTimesheet();
            var dom = objRepo.GetDomain();
            var salesperson = objRepo.GetSalesper();
            var paystate = objRepo.GetPayrollState();


            var PVM = new ProjectAddEditViewModel
            {
                ProjectSta = appRefStatus,
                ProjectCategories = appRefCategory,
                ProjectTypes = appRefType,
                ClientInvoiceGroups = appRefInvoice,
                TimesheetTypes = appRefSheetType,
                PracticeTypes = appRefPracticeType,
                Recruiters = Rec,
                Locationgroups = location,
                TimesheetRepresentatives = timesheet,
                SubDomains = dom,
                SalesPersons = salesperson,
                PayrollStates = paystate

            };


            return View(PVM);
        }
    }
}
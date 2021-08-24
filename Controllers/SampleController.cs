using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication2.Repository;
using WebApplication2.Models;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication2.Controllers
{
    public class ProjectController : Controller
    {
        private SqlConnection con;



        private void Connection()
        {
            string _conString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            con = new SqlConnection(_conString);

        }
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
        public ActionResult Save(ProjectAddEditViewModel model)
        {
            Connection();
            SqlCommand com = new SqlCommand("ProjectDetails_Nisarg_Training", con);
            com.CommandType = CommandType.StoredProcedure;
            
            com.Parameters.AddWithValue("@CustomerName", model.Project.CustomerName);
            com.Parameters.AddWithValue("@ProjectName", model.Project.ProjectName);
            com.Parameters.AddWithValue("@ProjectId", model.Project.ProjectId);
            com.Parameters.AddWithValue("@StartDate", model.Project.StartDate);
            com.Parameters.AddWithValue("@EndDate", model.Project.EndDate);
            com.Parameters.AddWithValue("@ProjectStatus", model.Project.ProjectStatus);
            com.Parameters.AddWithValue("@LocationGroup", model.Project.LocationGroup);
            com.Parameters.AddWithValue("@PayrollState", model.Project.PayrollState);
            com.Parameters.AddWithValue("@SalesPerson", model.Project.SalesPerson);
            com.Parameters.AddWithValue("@ProjectCategory", model.Project.ProjectCategory);
            com.Parameters.AddWithValue("@ProjectType", model.Project.ProjectType);
            com.Parameters.AddWithValue("@SubDomain", model.Project.SubDomain);
            com.Parameters.AddWithValue("@TimesheetRepresentative", model.Project.TimesheetRepresentative);
            com.Parameters.AddWithValue("@ClientInvoiceGroup", model.Project.ClientInvoiceGroup);
            com.Parameters.AddWithValue("@TimesheetType", model.Project.TimesheetType);
            com.Parameters.AddWithValue("@IsVmsTimesheet", model.Project.IsVmsTimesheet);
            com.Parameters.AddWithValue("@PracticeType", model.Project.PracticeType);
            com.Parameters.AddWithValue("@Recruiter", model.Project.Recruiter);
            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return View();
            }
            else
            {
                return View();
            }
        }
        public ActionResult GetList()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AddProject()
        {
            return View();
        }

    }
}

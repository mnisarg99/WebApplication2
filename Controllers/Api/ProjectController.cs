using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Repository;

namespace WebApplication2.Controllers.Api
{
    public class ProjectController : ApiController
    {
        [HttpPost]
        [Route("Sample/AddProjectNisarg")]
        public IHttpActionResult AddProject(ProjectController Pr)
        {
            common objRepo = new common();
            var appRefStatus = objRepo.GetAppRefData(1800);
            return Ok(appRefStatus);
         
        }

        [HttpGet]
        [Route("Sample/GetProjectStatusNisarg")]
        public IHttpActionResult ProjectStatus(int parentId)
        {
            common objRepo = new common();
            var appRefStatus = objRepo.GetAppRefData(parentId);
            return Ok(appRefStatus);
        }

        [HttpGet]
        [Route("Sample/GetProjectCategoryNisarg")]
        public IHttpActionResult ProjectCategory(int parentId)
        {
            common objRepo = new common();
            var appRefCategory = objRepo.GetAppRefData(parentId);
            return Ok(appRefCategory);
        }

        [HttpGet]
        [Route("Sample/GetProjectTypeNisarg")]
        public IHttpActionResult ProjectType(int parentId)
        {
            common objRepo = new common();
            var appRefType = objRepo.GetAppRefData(parentId);
            return Ok(appRefType);
        }

        [HttpGet]
        [Route("Sample/GetProjectInvoiceNisarg")]
        public IHttpActionResult ProjectInvoice(int parentId)
        {
            common objRepo = new common();
            var appRefInvoice = objRepo.GetAppRefData(parentId);
            return Ok(appRefInvoice);
        }

        [HttpGet]
        [Route("Sample/GetProjectTimesheetTypeNisarg")]
        public IHttpActionResult ProjectTimesheetType(int parentId)
        {
            common objRepo = new common();
            var appRefSheetType = objRepo.GetAppRefData(parentId);
            return Ok(appRefSheetType);
        }

        [HttpGet]
        [Route("Sample/GetProjectPracticeTypeNisarg")]
        public IHttpActionResult ProjectPracticeType(int parentId)
        {
            common objRepo = new common();
            var appRefPracticeType = objRepo.GetAppRefData(parentId);
            return Ok(appRefPracticeType);
        }

        [HttpGet]
        [Route("Sample/GetProjectRecruiterNisarg")]
        public IHttpActionResult ProjectRecruiter()
        {
            common objRepo = new common();
            var Rec = objRepo.GetRecr();
            return Ok(Rec);
        }

        [HttpGet]
        [Route("Sample/GetProjectLocationGroupNisarg")]
        public IHttpActionResult ProjectLocationGroup()
        {
            common objRepo = new common();
            var location = objRepo.GetLocation();
            return Ok(location);
        }

        [HttpGet]
        [Route("Sample/GetProjectTimesheetRepresentativeNisarg")]
        public IHttpActionResult ProjectTimesheetRepresentative()
        {
            common objRepo = new common();
            var timesheet = objRepo.GetTimesheet();
            return Ok(timesheet);
        }

        [HttpGet]
        [Route("Sample/GetProjectSubDomainNisarg")]
        public IHttpActionResult ProjectSubDomain()
        {
            common objRepo = new common();
            var dom = objRepo.GetTimesheet();
            return Ok(dom);
        }

        [HttpGet]
        [Route("Sample/GetProjectSalesPersonNisarg")]
        public IHttpActionResult ProjectSalesPerson()
        {
            common objRepo = new common();
            var salesperson = objRepo.GetSalesper();
            return Ok(salesperson);
        }

        [HttpGet]
        [Route("Sample/GetProjectPayrollStateNisarg")]
        public IHttpActionResult ProjectPayrollState()
        {
            common objRepo = new common();
            var paystate = objRepo.GetPayrollState();
            return Ok(paystate);
        }
    }
}

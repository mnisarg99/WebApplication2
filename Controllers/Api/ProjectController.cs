using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;
using WebApplication2.Repository;

namespace WebApplication2.Controllers.Api
{
    public class ProjectController : ApiController
    {
        [HttpPost]
        [Route("ProjectApi/AddProject1")]
        public IHttpActionResult AddProject(Project Pr)
        {
            DataTab objRepo = new DataTab();
            var dataTable = objRepo.SaveData(Pr);
            return Ok(dataTable);
            
        }

        [HttpPost]
        [Route("ProjectApi/UpdateProject")]
        public IHttpActionResult UpdateProject(Project Pr)
        {
            DataTab objRepo = new DataTab();
            var dataTable = objRepo.UpdateData(Pr);
            return Ok(dataTable);
        }

        [HttpGet]
        [Route("ProjectApi/GetProjectStatus")]
        public IHttpActionResult ProjectStatus(int parentId)
        {
            common objRepo = new common();
            var appRefStatus = objRepo.GetAppRefData(parentId);
            return Ok(appRefStatus);
        }

        [HttpGet]
        [Route("ProjectApi/GetProjectCategory")]
        public IHttpActionResult ProjectCategory(int parentId)
        {
            common objRepo = new common();
            var appRefCategory = objRepo.GetAppRefData(parentId);
            return Ok(appRefCategory);
        }

        [HttpGet]
        [Route("ProjectApi/GetProjectType")]
        public IHttpActionResult ProjectType(int parentId)
        {
            common objRepo = new common();
            var appRefType = objRepo.GetAppRefData(parentId);
            return Ok(appRefType);
        }

        [HttpGet]
        [Route("ProjectApi/GetProjectInvoice")]
        public IHttpActionResult ProjectInvoice(int parentId)
        {
            common objRepo = new common();
            var appRefInvoice = objRepo.GetAppRefData(parentId);
            return Ok(appRefInvoice);
        }

        [HttpGet]
        [Route("ProjectApi/GetProjectTimesheetType")]
        public IHttpActionResult ProjectTimesheetType(int parentId)
        {
            common objRepo = new common();
            var appRefSheetType = objRepo.GetAppRefData(parentId);
            return Ok(appRefSheetType);
        }

        [HttpGet]
        [Route("ProjectApi/GetProjectPracticeType")]
        public IHttpActionResult ProjectPracticeType(int parentId)
        {
            common objRepo = new common();
            var appRefPracticeType = objRepo.GetAppRefData(parentId);
            return Ok(appRefPracticeType);
        }

        [HttpGet]
        [Route("ProjectApi/GetProjectRecruiter")]
        public IHttpActionResult ProjectRecruiter()
        {
            common objRepo = new common();
            var Rec = objRepo.GetRecr();
            return Ok(Rec);
        }

        [HttpGet]
        [Route("ProjectApi/GetProjectLocationGroup")]
        public IHttpActionResult ProjectLocationGroup()
        {
            common objRepo = new common();
            var location = objRepo.GetLocation();
            return Ok(location);
        }

        [HttpGet]
        [Route("ProjectApi/GetProjectTimesheetRepresentative")]
        public IHttpActionResult ProjectTimesheetRepresentative()
        {
            common objRepo = new common();
            var timesheet = objRepo.GetTimesheet();
            return Ok(timesheet);
        }

        [HttpGet]
        [Route("ProjectApi/GetProjectSubDomain")]
        public IHttpActionResult ProjectSubDomain()
        {
            common objRepo = new common();
            var dom = objRepo.GetDomain();
            return Ok(dom);
        }

        [HttpGet]
        [Route("ProjectApi/GetProjectSalesPerson")]
        public IHttpActionResult ProjectSalesPerson()
        {
            common objRepo = new common();
            var salesperson = objRepo.GetSalesper();
            return Ok(salesperson);
        }

        [HttpGet]
        [Route("ProjectApi/GetProjectPayrollState")]
        public IHttpActionResult ProjectPayrollState(int countryId)
        {
            common objRepo = new common();
            var paystate = objRepo.GetPayrollState(countryId);
            return Ok(paystate);
        }

        [HttpGet]
        [Route("ProjectApi/GetAppRefData")]
        public IHttpActionResult GetAppRefData(int parentId)
        {
            common objRepo = new common();
            var appRefList = objRepo.GetAppRefData(parentId);
            return Ok(appRefList);
        }


        [HttpGet]
        [Route("ProjectApi/GetProjectsList")]
        public IHttpActionResult DataTab()
        {
            common objRepo = new common();
            var datatable = objRepo.GetProjectsList();
            return Ok(datatable);
        }

        [HttpGet]
        [Route("ProjectApi/GetProjectDataList")]
        public IHttpActionResult ProjectDataList(string Id)
        {
            DataTab objRepo = new DataTab();
            var datatable = objRepo.GetProjectData(Id);
            return Ok(datatable);
        }


    }
}

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
        [Route("Sample/Project")]
        public IHttpActionResult AddProject(ProjectController Pr)
        {
            return Ok();
        }

        [HttpGet]
        [Route("Sample/AppRefData")]
        public IHttpActionResult GetAppRefData(int parentId)
        {
            common objRepo = new common();
            var appRefStatus = objRepo.GetAppRefData(parentId);
            return Ok(appRefStatus);
        }
    }
}

using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace projectMemberLabTask.Controllers
{
    public class ProjectController : ApiController
    {
        [HttpGet]
        [Route("api/project/{status}")]
        public HttpResponseMessage Get(string Status)
        {
            try
            {

                return Request.CreateResponse(HttpStatusCode.OK, ProjectService.Get(Status));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }
    }
}

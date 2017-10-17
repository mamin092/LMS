using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Lms_Server.Controllers.Teacher
{
    using Lms.Model.Teacher;
    using Lms.Service;
    public class TeacherController : ApiController
    {
        public IHttpActionResult Post(Teacher teacher)
        {
            TeacherService service = new TeacherService();
            var add = service.Add(teacher);
            return this.Ok(add);
        }

    }
}

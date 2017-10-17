using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lms_Server.Controllers.Student
{
    using Lms.Model.Student;
    using Lms.Service;
    public class StudentController : ApiController
    {
        public IHttpActionResult Post(Student student)
        {
            StudentService service = new StudentService();
            var add = service.Add(student);
            return this.Ok(add);
        }
    }
}

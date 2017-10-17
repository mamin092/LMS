using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.Model.Teacher;
using Lms.Repository;

namespace Lms.Service
{
  public  class TeacherService
  {

      public bool Add(Teacher teacher)
      {
          TeacherRepository repository = new TeacherRepository();
          return repository.Add(teacher);
      }

  }
}

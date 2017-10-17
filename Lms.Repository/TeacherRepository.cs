using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.Model;
using Lms.Model.Teacher;

namespace Lms.Repository
{
  public  class TeacherRepository
  {
      private BusinessDbContext db;

      public TeacherRepository()
      {
          this.db = new BusinessDbContext();
      }

      public bool Add(Teacher teacher)
      {
          teacher.Id = Guid.NewGuid().ToString();
          this.db.Teachers.Add(teacher);
          int saveChanges = this.db.SaveChanges();

          return saveChanges > 0;
      }
  }
}

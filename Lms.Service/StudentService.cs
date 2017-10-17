using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.Model.Student;
using Lms.Repository;

namespace Lms.Service
{
    public class StudentService
    {
        public bool Add(Student student)
        {
            StudentRepository repository = new StudentRepository();

            return repository.Add(student); 
        }

    }
}

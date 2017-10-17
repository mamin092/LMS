using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Model
{
    public class BusinessDbContext : DbContext
    {
        public BusinessDbContext() : base("DefaultBusinessConnection")
        {
            
        }

        public DbSet<Student.Student> Students { get; set; }

        public DbSet<Teacher.Teacher> Teachers { get; set; }
    }
}

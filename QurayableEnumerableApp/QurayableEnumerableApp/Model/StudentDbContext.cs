using QurayableEnumerableApp.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QurayableEnumerableApp.Model
{
    class StudentDbContext : DbContext
    {
        public DbSet<Student> studentDb { get; set; }

        public void AddStudent(Student student)
        {
            studentDb.Add(student);
        }
        
    }
}

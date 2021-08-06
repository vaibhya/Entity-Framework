using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QurayableEnumerableApp.Data
{
    class Student
    {
        [Key]
        public Guid guid { get; set; }
        public string FullName { get; set; }
        public double Cgpa { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentCRUDApp.Models.Service;
using StudentCRUDApp.Models.Data;

namespace StudentCRUDApp.Models.ViewModel
{
    public class DisplayVm
    {
        public string Guid { get; set; }
        public string Name { get; set; }
        public string RollNo { get; set; }
        public Double Cgpa { get; set; }

        public List<Student> StudentList { get; set; }
    }
}
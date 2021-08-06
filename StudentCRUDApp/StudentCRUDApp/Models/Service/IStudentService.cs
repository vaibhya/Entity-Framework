using StudentCRUDApp.Models.Data;
using System.Collections.Generic;

namespace StudentCRUDApp.Models.Service
{
    public interface IStudentService
    {
        void AddStudent(Student s);
        void DeleteStudent(Student s);
        List<Student> GetStudents();
    }
}
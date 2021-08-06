using StudentCRUDApp.Models.Data;
using System.Collections.Generic;

namespace StudentCRUDApp.Models.Repository
{
    public interface IStudentRepository
    {
        void Add(Student student);
        List<Student> Get();
        void Remove(Student student);
    }
}
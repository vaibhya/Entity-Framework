using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentCRUDApp.Models.Data;
using StudentCRUDApp.Models.Repository;

namespace StudentCRUDApp.Models.Service
{

    public class StudentService : IStudentService
    {
        private IStudentRepository _repository;
        public StudentService()
        {
            //_repository = new StudentRepository();
            _repository = StudentRepository.GetInstance;
        }
        public List<Student> GetStudents()
        {
            return _repository.Get();
        }
        public void AddStudent(Student s)
        {
            _repository.Add(s);
        }
        public void DeleteStudent(Student s)
        {
            _repository.Remove(s);
        }
    }
}
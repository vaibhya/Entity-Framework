using QurayableEnumerableApp.Data;
using QurayableEnumerableApp.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QurayableEnumerableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDbContext db = new StudentDbContext();

            //db.AddStudent(new Student { guid = Guid.NewGuid(), FullName = "Sachin Tendulkar", Cgpa = 9 });
            //db.AddStudent(new Student { guid = Guid.NewGuid(), FullName = "Sidharth Tendulkar", Cgpa = 8 });
            //db.AddStudent(new Student { guid = Guid.NewGuid(), FullName = "Vaibhav kamble", Cgpa = 8 });
            //db.AddStudent(new Student { guid = Guid.NewGuid(), FullName = "Atul Dethe", Cgpa = 9 });
            //db.AddStudent(new Student { guid = Guid.NewGuid(), FullName = "Vishal Kolekar", Cgpa = 6 });
            //QureybleCase1(db);
            QueryableCase2(db);
            //db.SaveChanges();
        }

        private static void QueryableCase2(StudentDbContext db)
        {
            var nameStartingWithS = db.studentDb
                                    .Where(s => s.FullName.StartsWith("S"))
                                    .ToList()
                                    .Select(s => new
                                    {
                                        FirstName = s.FullName.Split(' ')[0],
                                        Cgpa = s.Cgpa
                                    });
            Console.WriteLine(nameStartingWithS);
            var studentList = nameStartingWithS.ToArray();
            foreach (var student in studentList)
            {
                Console.WriteLine(student.FirstName);
                Console.WriteLine(student.Cgpa);
            }
        }

        private static void QureybleCase1(StudentDbContext db)
        {
            var nameStartingWithS = db.studentDb
                                    .Where(s => s.FullName.StartsWith("S"))

                                    .Select(s => new
                                    {
                                        s.FullName,
                                        s.Cgpa
                                    });
            Console.WriteLine(nameStartingWithS);
            var studentList = nameStartingWithS.ToArray();
            foreach(var student in studentList)
            {
                Console.WriteLine(student.FullName);
                Console.WriteLine(student.Cgpa);
            }
        }
    }
}

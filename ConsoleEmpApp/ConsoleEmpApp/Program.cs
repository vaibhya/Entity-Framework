using ConsoleEmpApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEmpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AurionProDbContext db = new AurionProDbContext();
            //Customer c1 = new Customer { Id = 4, Name = "aman", Location = "nerul" };
            //Customer c2 = new Customer { Id = 5, Name = "aarti", Location = "vashi" };
            //Customer c3 = new Customer { Id = 6, Name = "aaish", Location = "nerul" };

            //db.AddDb(c1);
            //db.AddDb(c2);
            //db.AddDb(c3);
            //db.SaveChanges();

            Customer c1 = new Customer { Id = 6, Name = "aaish", Location = "nerul" ,Balance=300,Type="x"};

            db.AddDb(c1);
            db.SaveChanges();

            //IEnumerable<Customer> list = db.Customer.Where(c => c.Location.Equals("nerul"));
            //String query2 = list.ToString();
            //list = list.Take<Customer>(2);
            
            //Console.WriteLine(query2);
            //foreach(var item in list)
            //{
            //    Console.WriteLine(item.Id + item.Name + item.Location);
            //}

            //IQueryable<Customer> qList = db.Customer.Where(c => c.Location.Equals("nerul"));
            //qList = qList.Take<Customer>(2);
            //String query = qList.ToString();
            //Console.WriteLine(query);
            //foreach (var item in qList)
            //{
            //    Console.WriteLine(item.Id + item.Name + item.Location);
            //}



        }
    }
}

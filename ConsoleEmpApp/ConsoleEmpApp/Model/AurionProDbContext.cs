using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleEmpApp.Model
{
    public class AurionProDbContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }

        public void AddDb(Customer customer)
        {
            Customer.Add(customer);
        }

    }
}

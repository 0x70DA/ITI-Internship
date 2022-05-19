using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Model1 context = new Model1())
            {
                Employee E1 = new Employee() { Name = "Mahmoud" };
                context.Employees.Add(E1);
                context.SaveChanges();
                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Marvin",456,30000,"");
            emp.GiveBonus(1000);
            emp.DisplayStats();
            emp.Name ="Xena the warrior princess";
            Console.WriteLine("Emp name is: {0}",emp.Name);

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {
        
        public string SSN { get { return empSSN; } }
        public int Age { get { return empAge; } set { empAge = value; } }

        /*public string GetName()
        {
            return empName;
        }
        public void SetName(string name)
        {
            if (name.Length > 15)
                Console.WriteLine("Error!");
            else
                empName = name;
        }*/
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error!");
                else
                    empName = value;
            }
        }
        public int ID { get { return empID; } set { empID = value; } }
        public float Pay { get { return currPay; } set { currPay = value; } }

        public void GiveBonus(float amount)
        {
            Pay += amount;
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0} ",Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Pay: {0}", Pay);
        }
    }
}

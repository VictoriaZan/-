using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    sealed class PTSalesPerson:SalesPerson
    {
        public PTSalesPerson(string fullName, int age, int empId,
            float currPay, string ssn, int numbOfSales)
            : base(fullName, age, empId, currPay, ssn, numbOfSales)
        {
        }
    }
}

using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class SalesPerson: Employee
    {
        private double _succesSaleRevenue { get; set; }
        public SalesPerson(string firstName, string lastName)
        {
            Salary = 500;
            Role = RoleEnum.Sales;
            FirstName = firstName;
            LastName = lastName;
        }
        public void AddSuccessRevenue(double revenue)
        {
            _succesSaleRevenue = revenue;
        }
        public override double GetSalary()
        {
            if (_succesSaleRevenue <= 2000)
            {
                return Salary + 500;
            }
            else if (_succesSaleRevenue > 200 && _succesSaleRevenue <= 5000)
            {
                return Salary + 1000;
            }
            else if (_succesSaleRevenue > 5000)
            {
                return Salary + 1500;
            }
            else
            {
                return Salary;
            }

        }
    }
}

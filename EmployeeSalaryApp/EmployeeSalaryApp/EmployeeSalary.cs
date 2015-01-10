using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryApp
{
    class EmployeeSalary
    {
        public string name;
        public double basic;
        public double houseRentPercent;
        public double medicalAllowancePercent;

        public double CalculateTotal()
        {
            return basic + GetHouseRentAmount() + GetMedicalAmount();
        }

        private double GetMedicalAmount()
        {
            return (medicalAllowancePercent*basic)/100;
        }

        private double GetHouseRentAmount()
        {
            return (houseRentPercent*basic)/100;
        }
    }
}

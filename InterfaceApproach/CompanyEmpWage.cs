using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApproach
{
    class CompanyEmpWage
    {
        public String company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(String company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;

        }
        public void setTotalEmpWage(int totalEmpWage)
        {
          //  Console.WriteLine("called");
           // Console.WriteLine("value of totalEmpWage" + totalEmpWage);

            this.totalEmpWage = totalEmpWage;
           // Console.WriteLine("value of totalEmpWage" + totalEmpWage);
        }
        public String toString()
        {
            return "Tatal Emp Wage For Company " + this.company + " is :" + totalEmpWage;
        }

    }
}

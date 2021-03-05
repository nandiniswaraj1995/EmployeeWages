using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApproach
{
    class EmpWageBuilderArray
    {
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;

        private int numOfCompany = 0;
        private CompanyEmpWage[] CompanyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.CompanyEmpWageArray = new CompanyEmpWage[5];

        }
        public void addCompanyEmpWage(String company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for(int i = 0;i<numOfCompany;i++)
                {
                CompanyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.CompanyEmpWageArray[i]));
                Console.WriteLine(this.CompanyEmpWageArray[i].toString());

            }
        }

        public int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            

            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays <= companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();

                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "emp Hrs:" + empHrs);
            }

             return totalEmpHrs * companyEmpWage.empRatePerHour;
            


        }

    }

}
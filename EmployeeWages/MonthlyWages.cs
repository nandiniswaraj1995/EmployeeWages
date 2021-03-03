using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class MonthlyWages
    {
        public static void monthlyWages()
        {
            int IS_PRESENT = 1;
            int EMP_RATE_PER_HOUT = 20;
            int empHrs = 8;
            int empWage = 0;
            int count = 0;
            Random random = new Random();
            for (int i = 1; i <= 20; i++)
            {
                int empCheck = random.Next(0, 2);
                if (empCheck == IS_PRESENT)
                {
                    count++;
                    
                }

            }
            empWage = count * empHrs * EMP_RATE_PER_HOUT;

            Console.WriteLine("Employee Wages For "+count+" Working Days :" + empWage);
            


    }

}
}

using System;

namespace InterfaceApproach
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart",20,2,10);
            empWageBuilder.addCompanyEmpWage("Relaince",10,4,20);
            empWageBuilder.computeEmpWage();


        }
    }
}

using System;

namespace AbilityToManageEmpWageOfMulCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();

            Console.ReadKey();
        }
    }
}

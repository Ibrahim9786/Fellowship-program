using System;
using System.Collections.Generic;
using System.Text;

namespace AbilityToManageEmpWageOfMulCompany
{
    class EmpWageBuilderArray
    {
        public const int PartTime = 1;
        public const int FullTime = 2;

        private int numOfCompanies = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        } 

        public void addCompanyWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompanies] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompanies++;
        }

        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompanies; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while(totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch(empCheck)
                {
                    case PartTime:
                        empHrs = 4;
                        break;
                    case FullTime:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs :" + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
    }
}

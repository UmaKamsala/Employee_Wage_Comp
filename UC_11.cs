using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Comp
{
    class UC_11
    {
        private const int IS_FULL_TIME = 1;
        private const int IS_PART_TIME = 2;

        private LinkedList<UC_10> CompanyEmpWageLists;
        private Dictionary<string, UC_10> CompanyToEmpWageMap;

        public UC_11()
        {
            this.CompanyEmpWageLists = new LinkedList<UC_10>();
            this.CompanyToEmpWageMap = new Dictionary<string, UC_10>();
        }
        public void addCompany(string company, int empRatePerHr, int numWorkingDays, int maxHrsInMonth)
        {
            UC_10 companyLists = new UC_10(company, empRatePerHr, numWorkingDays, maxHrsInMonth);
            this.CompanyEmpWageLists.AddLast(companyLists);
            this.CompanyToEmpWageMap.Add(company, companyLists);
        }
        public void ComputeEmpWage()
        {
            foreach (UC_10 companyLists in this.CompanyEmpWageLists)
            {
                companyLists.setTotalEmpWage(this.ComputeEmpWage(companyLists));
                Console.WriteLine(companyLists.toString());
            }
        }

        private int ComputeEmpWage(UC_10 companyLists)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0, empWage = 0;

            while (totalEmpHrs <= companyLists.MAX_HRS_IN_MONTH && totalWorkingDays < companyLists.NO_WORKING_DAYS)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                empWage = empHrs * companyLists.EMP_RATE_PER_HOUR;
                companyLists.dailyWage[totalWorkingDays] = empWage;
                totalWorkingDays++;
            }
            Console.WriteLine("Company Name " + companyLists.Company);
            Console.WriteLine("No Of Days #:" + totalWorkingDays + " No Of Hrs: " + totalEmpHrs);
            for (int i = 0; i < companyLists.dailyWage.Length; i++)
            {
                Console.WriteLine("Daily Wage {0} is:  " + companyLists.dailyWage[i], i + 1);
            }
            return totalEmpHrs * companyLists.EMP_RATE_PER_HOUR;
        }

        public int GetTotlaWage(string company)
        {
            return this.CompanyToEmpWageMap[company].totalEmpWage;
        }
    }
}




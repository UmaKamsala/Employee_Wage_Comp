using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Comp
{
    class UC_9
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        private string Company;
        private int EMP_RATE_PER_HOUR;
        private int NUM_WORKING_DAYS;
        private int MAX_HRS_IN_MONTH;
        private int totalEmpWage;

        public UC_9(string company, int empRatePerHr, int numWorkingDays, int maxHrsInMonth)
        {
            this.Company = company;
            this.EMP_RATE_PER_HOUR = empRatePerHr;
            this.NUM_WORKING_DAYS = numWorkingDays;
            this.MAX_HRS_IN_MONTH = maxHrsInMonth;
        }

        public void ComputeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0, empWage = 0;

            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_WORKING_DAYS)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                totalWorkingDays++;
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
                empWage = empHrs * EMP_RATE_PER_HOUR;

                Console.WriteLine("Day#:" + totalWorkingDays + " EmpHrs: " + empHrs + " Daily Wage is: " + empWage);
            }
            totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
        }
        public string toString()
        {
            return "Monthly Employee Wage for Company : " + Company + " is : " + totalEmpWage;
        }
    }
}




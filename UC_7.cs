using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Comp
{
    class UC_7
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;

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
                Console.WriteLine("Day#:" + totalWorkingDays + " EmpHrs: " + empHrs + " Wage is: " + empWage);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Monthly Employee Wage :" + totalEmpWage);
        }
    }
}
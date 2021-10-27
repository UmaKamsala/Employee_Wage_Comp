using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Comp
{
    class UC_5
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_WORKING_DAYS = 20;

        public void MonthlyWage()
        {
            int empHrs = 0, empWage = 0, totalEmpWage = 0; ;

            for (int day = 0; day < NUM_WORKING_DAYS; day++)
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
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Employee Daily Wage :" + empWage);
            }
            Console.WriteLine("Monthly Employee Wage :" + totalEmpWage);
        }
    }
}
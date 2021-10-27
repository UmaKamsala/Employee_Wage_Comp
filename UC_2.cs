using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Comp
{
    class UC_2
    {
        public const int IS_FULL_TIME = 1;
        public const int EMP_RATE_PER_HOUR = 20;
        public void DailyWage()
        {
            int empHrs = 0, empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Daily Wage :" + empWage);
        }
    }
}

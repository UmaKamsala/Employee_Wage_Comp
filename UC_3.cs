using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Comp
{
    class UC_3
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;

        public void PartTime()
        {
            int empHrs = 0, empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee Full TIME Present");
                empHrs = 8;
            }
            else if (empCheck == IS_PART_TIME)
            {
                Console.WriteLine("Employee PART TIME Present");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Daily Wage :" + empWage);
        }
    }
}

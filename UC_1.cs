using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Comp
{
    class UC_1
    {
        public const int IS_FULL_TIME = 1;
        public void Attendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee FULL TIME Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}

using System;

namespace Employee_Wage_Comp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                Console.WriteLine("Welcome to Employee Wage Computation");

                UC_1 uc1 = new UC_1();
                uc1.Attendance();

                UC_2 uc2 = new UC_2();
                uc2.DailyWage();

                UC_3 uc3 = new UC_3();
                uc3.PartTime();

                UC_4 uc4 = new UC_4();
                uc4.Case();

                UC_5 uc5 = new UC_5();
                uc5.MonthlyWage();

                UC_6 uc6 = new UC_6();
                uc6.Condition();

                UC_7 uc7 = new UC_7();
                uc7.ComputeEmpWage();
            }
        }
    }

}
    
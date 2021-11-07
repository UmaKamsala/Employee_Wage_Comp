using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Comp
{
    class UC_10
    {
        public string Company;
        public int EMP_RATE_PER_HOUR;
        public int NO_WORKING_DAYS;
        public int MAX_HRS_IN_MONTH;
        public int totalEmpWage;
        public int[] dailyWage;


        public UC_10(string company, int empRatePerHr, int numWorkingDays, int maxHrsInMonth)
        {
            this.Company = company;
            this.EMP_RATE_PER_HOUR = empRatePerHr;
            this.NO_WORKING_DAYS = numWorkingDays;
            this.MAX_HRS_IN_MONTH = maxHrsInMonth;
            this.dailyWage = new int[NO_WORKING_DAYS];
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Monthly Employee Wage for Company : " + this.Company + " is : " + this.totalEmpWage;
        }
    }
}
 







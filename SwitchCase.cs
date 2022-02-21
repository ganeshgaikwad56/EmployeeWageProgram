using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class SwitchCase
    {
        public static void SwitchCaseCal()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int NUM_OF_WORKING_DAYS = 20;

            int EmpHrs = 0;
            int EmpWage = 0;
            int MonthWage=0;

            Random random = new Random();
            int EmpCheck = random.Next(3);

            switch(EmpCheck)
            {
                case IS_FULL_TIME:
                    EmpHrs = 8;
                    break;

                case IS_PART_TIME:
                    EmpHrs = 4;
                    break;

                default:
                    EmpHrs = 0;
                    break;
            }
            EmpWage = EmpHrs * EMP_RATE_PER_HOUR;
            MonthWage = EmpWage * NUM_OF_WORKING_DAYS;
            Console.WriteLine("Employee Wage " + EmpWage);
            Console.WriteLine("Employee Wage " + MonthWage);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    public class CalEmpDailyWage
    {
        public static void CalculateWage()
        {
            
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            int EmpHrs = 0;
            int EmpWage = 0;

            Random random = new Random();
            int EmpCheck = random.Next(3);

            if (EmpCheck == 1)
            {
                EmpHrs = 8;
            }
            else if (EmpCheck == 2)
            {
            
                EmpHrs = 4;
            }
            else 
            {
                EmpHrs = 0;
            }
            EmpWage = EmpHrs * EMP_RATE_PER_HOUR;

            Console.WriteLine("Employee Wage is " +EmpWage);
        }
    }
}

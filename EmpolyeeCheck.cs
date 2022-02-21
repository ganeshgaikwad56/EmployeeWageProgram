using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    public class EmpolyeeCheck
    {
        public static void EmployeePresentOrNot()

        {
           // int IS_PART_TIME = 1;
            int IS_FULL_TIME = 1;
            //int EMP_RATE_PER_HOUR = 20;

            //int EmpHrs = 0;
            //int EmpWage = 0;

            Random random = new Random();
            int Employee = random.Next(2);

            if (Employee == IS_FULL_TIME)
            {
                Console.WriteLine("Employee Is Present");
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
            }
        }
    }
}

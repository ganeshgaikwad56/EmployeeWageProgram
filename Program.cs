using System;

namespace EmployeeWageProgram
{
    class Program

    {
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome To Employee Wage Program");
            EmpolyeeCheck.EmployeePresentOrNot();
            CalEmpDailyWage.CalculateWage();
            SwitchCase.SwitchCaseCal();
        }
    }
}



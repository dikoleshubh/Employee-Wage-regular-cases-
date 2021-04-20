using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    class WageComputation
    {
        static void Wage_Compute()
        {
            int FULL_TIME = 1;
            int PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int emphrs = 0;
            int empWage = 0;
            Random random = new Random();
            int EmpCheck = random.Next(0, 3); ////Random Function for Hours calculation
            if (EmpCheck == FULL_TIME) ////Full time employee
            {
                emphrs = 8;

            }
            else if (EmpCheck == PART_TIME)////Full time employee
            {
                emphrs = 4;
            }
            else
            {
                emphrs = 0;
            }
            empWage = EMP_RATE_PER_HOUR * emphrs;//// Emp Wage calculation

            Console.WriteLine("Employe Wage Per Day:- " + empWage);
        }
    }
}

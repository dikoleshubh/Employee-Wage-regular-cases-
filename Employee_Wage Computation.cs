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
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int emphrs = 0;
            int empWage = 0;
            Random random = new Random();
            int EmpCheck = random.Next(0, 3); ////Random Function for Employee selection
            switch (EmpCheck)          //Switch case Statment
            {
                case FULL_TIME:         //Employee is FullTime
                    emphrs = 8;
                    break;
                case PART_TIME:          //Employee is Part Time
                    emphrs = 4;
                    break;
                default:
                    emphrs = 0;
                    break;
            }
            empWage = EMP_RATE_PER_HOUR * emphrs;//// Emp Wage calculation
            Console.WriteLine("Employe Wage Per Day:- " + empWage);
        }
    }
}

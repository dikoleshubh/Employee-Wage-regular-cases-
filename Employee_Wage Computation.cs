using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    class WageComputation
    {
        public static void Wage_Compute()
        {
            const int FULL_TIME = 1; ////Employee Constants
            const int PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int emphrs = 0, workingdays=20;
            int empWage = 0 , totalempwage;
            int days = 0;
            Random random = new Random();
            int EmpCheck = random.Next(0, 3); ////Random Function for Employee selection
            
            while (days < workingdays)////condtion check for Employee exceeding days i.e. 20
            {
                days++;

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
            }
            empWage = EMP_RATE_PER_HOUR * emphrs;//// Emp Wage calculation/day
            totalempwage = empWage * days;

            Console.WriteLine("Employe Wage Per Day & Month:- " + empWage +totalempwage);
            return totalempwage;

        }
    }
}

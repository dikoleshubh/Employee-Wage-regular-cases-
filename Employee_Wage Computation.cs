using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    class WageComputation
    {
        public static int Wage_Compute(string company, int EMP_RATE_PER_HOUR,int workingDays,int maxhours)
        {
            const int FULL_TIME = 1; 
            const int PART_TIME = 2;
            
            int emphrs = 0;
            int empWage = 0 , totalempwage;
            int days = 0;
            Random random = new Random();
            int EmpCheck = random.Next(0, 3); ////Random Function for Employee selection
            
            while (days < workingDays && emphrs < maxhours)////condtion check for Employee exceeding days
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
            Console.WriteLine($"Name of Compnay is {company} " );
            Console.WriteLine("Employe Wage Per Day & Month:- " + empWage +totalempwage);
            return (totalempwage);
            
        }
    }
}

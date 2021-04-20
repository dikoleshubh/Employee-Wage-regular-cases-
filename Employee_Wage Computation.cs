using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    class EmployeeWageComputation
    {
        

        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalempwage;
        public EmployeeWageComputation(string company, int empRatePerHour, int WorkingDays, int maxhours)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = WorkingDays;
            this.maxHoursPerMonth = maxhours;

        }
    
        
    

        public  void Wage_Compute()
        {
            const int FULL_TIME = 1; 
            const int PART_TIME = 2;
            
            int emphrs = 0;
            int empWage = 0 , totalempwage;
            int days = 0;
            Random random = new Random();
            int EmpCheck = random.Next(0, 3); ////Random Function for Employee selection
            
            while (days < this.numOfWorkingDays && emphrs < this.maxHoursPerMonth)////condtion check for Employee exceeding days
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
            empWage = empRatePerHour * emphrs;//// Emp Wage calculation/day
            totalempwage = empWage * days;
                                                      //Display empwage
            totalempwage = totalempwage + empWage;      //Calculate total employe month wage
            empWage = empRatePerHour * emphrs;

            Console.WriteLine($"Name of Compnay is {company} " );
            Console.WriteLine("Employe Wage Per Day & Month:- " + empWage +totalempwage);
            
            
        }
        public string toString()
        {
            return "Total Emp Wage for company :- " + company + "is :- " + totalempwage;
        }
    }
}

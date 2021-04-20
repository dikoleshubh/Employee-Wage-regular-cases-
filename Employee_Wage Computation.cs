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
        public void setTotalEmpWage(int TotalEmpWage)
        {
            this.totalempwage = totalempwage;
        }
        public string toString()
        {
            return "Total Emp Wage for company :- " + company + " is :- " + totalempwage;
        }
    }
        public class EmpWageBuilderArray
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            public int numCompany = 0;
            private EmployeeWageComputation[] EmployeeArray;

            public EmpWageBuilderArray()
            {
                this.EmployeeArray = new EmployeeWageComputation[5];
            }
            public void addComapnyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
            {
                EmployeeArray[this.numCompany] = new EmployeeWageComputation(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
                numCompany++;
            }
            public void Wage_Compute()
            {
                for (int i = 0; i < numCompany; i++)
                {
                    EmployeeArray[i].setTotalEmpWage(this.Wage_Compute(this.EmployeeArray[i]));
                    Console.WriteLine(this.EmployeeArray[i].toString());
                }
            }

            private int Wage_Compute(EmployeeWageComputation EmployeeWageComputation)
            {
                

                int emphrs = 0 ,hrs=0;
                int empWage = 0, totalempwage;
                int days = 0;
                Random random = new Random();
                int EmpCheck = random.Next(0, 3); ////Random Function for Employee selection

                while (days < EmployeeWageComputation.numOfWorkingDays  && emphrs < EmployeeWageComputation.maxHoursPerMonth)////condtion check for Employee exceeding days
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
                //// Emp Wage calculation/day
                totalempwage = empWage * days;
                
                totalempwage = totalempwage + empWage;      //Calculate total employe month wage

                hrs += emphrs;

                Console.WriteLine("Day " + days + " Emp hrs:- " + emphrs);//Display empwage

                Console.WriteLine("Employe Wage Per Day & Month:- " + empWage + totalempwage);

                return emphrs * EmployeeWageComputation.empRatePerHour;

            }
        }


    
}

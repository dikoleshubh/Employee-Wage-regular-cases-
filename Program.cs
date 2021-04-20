using System;

namespace Employee_Wage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EMPLOYEE WAGE ");
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addComapnyEmpWage("Dmart", 20, 2, 10);  //call method
            empWageBuilder.addComapnyEmpWage("Relicance", 10, 4, 20); //call method
            empWageBuilder.Wage_Compute(); //call method




        }
    }
}
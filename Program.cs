using System;

namespace Employee_Wage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EMPLOYEE WAGE ");
            EmployeeWageComputation mart = new EmployeeWageComputation("WhateverMArt", 20, 100,200);
            EmployeeWageComputation nmart = new EmployeeWageComputation("Flipkart", 20, 104, 200);



            mart.Wage_Compute(); //call method
            Console.WriteLine(mart.toString());
            nmart.Wage_Compute();//call method
            Console.WriteLine(nmart.toString());
        }
    }
}
using System;

namespace Employee_Wage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EMPLOYEE WAGE ");
            WageComputation.Wage_Compute("Walmart", 100, 20, 50);
            WageComputation.Wage_Compute("WHATEVER Mart", 110, 20, 50);
        }
    }
}
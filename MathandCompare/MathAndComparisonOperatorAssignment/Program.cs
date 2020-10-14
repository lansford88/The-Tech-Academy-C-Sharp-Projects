using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anyonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person1");
            Console.ReadLine();

            Console.WriteLine("What is your hourly Rate?");
            double hourRate = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("How many hours do you work per week?");
            int hoursWorked = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Person2");
            Console.ReadLine();

            Console.WriteLine("What is your hourly Rate?");
            double hourRateP2 = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("How many hours do you work per week?");
            int hoursWorkedP2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            double annSalP1 = hoursWorked * hourRate * 52;
            Console.WriteLine("Person1 your annual salary is : " + annSalP1);
            Console.ReadLine();

            double annSalP2 = hoursWorkedP2 * hourRateP2 * 52;
            Console.WriteLine("Person2 your annual salary is : " + annSalP2);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool compareValues = annSalP1 > annSalP2;
            Console.WriteLine(compareValues);
            Console.ReadLine();
        }
    }
}

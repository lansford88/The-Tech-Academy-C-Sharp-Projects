using System;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow instructions below");
            Console.ReadLine();

            Console.WriteLine("Please enter your package WEIGHT");
            int packWeight = Convert.ToInt32(Console.ReadLine());

            if (packWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
            }
            else if (packWeight <= 50)
            
                Console.WriteLine("Please enter package width:");
                int widthVar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter package height:");
                int heightVar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter package length:");
                int lengthVar = Convert.ToInt32(Console.ReadLine());

            int costPre = widthVar * heightVar * lengthVar;
            double totalCost = costPre / 100;

            if (widthVar + heightVar + lengthVar >= 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
            }
            else
                Console.WriteLine("Your estimated total cost for shipping this package is: $" + totalCost);
                Console.ReadLine();
                Console.WriteLine("Thank you for your business");
                Console.ReadLine();
            
            }
        }
    }

using System;
using System.Collections.Generic;

namespace Try_Catch_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // TRY CATCH ASSIGNMENT
            // I created a list that has a few integers saved to it
            // I ask the user to pick a number and I will divide that choice
            // then I save that choice as a variable. I placed this in try catch
            // to render any errors to the screen.

            try
            {
                List<int> numDiv = new List<int>() { 100, 200, 300, 400 };

                Console.WriteLine("pick a number and I will divide that number by the list I have.");
                int numPicked = Convert.ToInt32(Console.ReadLine());


                foreach (var item in numDiv)
                {
                    var result = item / numPicked;
                    Console.WriteLine(result);
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please only use numbers");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't use Zero");
            }
            
            Console.ReadLine();
            
        }
    }
}

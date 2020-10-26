using System;

namespace Console_Assignment_297__DateTime_Practice
{
    class Program
    {
        static void Main(string[] args)
        {   //This will give you the time that is NOW
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();

            //This asks the user to input a number and then assigns that number to the variable userInput
            Console.WriteLine("\nPlease choose a number : ");
            int userInput = Convert.ToInt32(Console.ReadLine());
             Console.ReadLine();
            
            //DateTime.Now gives you the time now, adding .AddHours(built in) will let you add actual hours to DateTime.Now. in the parenthesis it takes the integer to add.
            Console.WriteLine(DateTime.Now.AddHours(userInput));
            Console.ReadLine();
        }
    }
}

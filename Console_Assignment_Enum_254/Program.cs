using System;
using System.Security.Cryptography.X509Certificates;

namespace Console_Assignment_Enum_254
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                DaysOfTheWeek days = new DaysOfTheWeek();                       //Instantiates the enum object
                Console.WriteLine("Please Pick a day of the week: ");
                string userInput = Console.ReadLine();

                days = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput);
                if (Enum.IsDefined(typeof(DaysOfTheWeek), days))
                {
                    Console.WriteLine(days);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter and actual day of the week");
            }
            Console.ReadLine();



            //**************************SECOND ATTEMPT****************
            //DaysOfTheWeek day1 = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), "Monday");

            //DaysOfTheWeek day2 = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), "Tuesday");

            //DaysOfTheWeek day3 = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), "Wednesday");

            //DaysOfTheWeek day4 = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), "Thursday");

            //DaysOfTheWeek day5 = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), "Friday");

            //DaysOfTheWeek day6 = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), "Saturday");

            //DaysOfTheWeek day7 = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), "Sunday");

          
            //************************First ATTEMPT**************

            //DaysOfTheWeek day = new DaysOfTheWeek();                //Instantiates the enum object
            //Console.WriteLine("Please Enter a day of the week");        //Asks user to pick a number
            //string userInput = Console.ReadLine();                              // assigns user input to variable


            //try
            //{
            //    day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Please enter an actual day of the week.");
            //}
            //Console.ReadLine();



        }
            
          public enum DaysOfTheWeek
        { 
            Monday=1,
            Tuesday=2,
            Wednesday=3,
            Thursday=4,
            Friday=5,
            Saturday=6,
            Sunday=7
        }
    }
}

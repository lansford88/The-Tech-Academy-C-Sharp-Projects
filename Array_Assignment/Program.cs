using System;
using System.Collections.Generic;

namespace Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] babyboyNames = { "Bob", "Tom", "Hank", "Jeff" };
            bool finished = false;
            while (!finished)
            {
                Console.WriteLine("Pick a number 0 through 3 to pick a new name");
                int b = Convert.ToInt32(Console.ReadLine());

                if (b > 3)
                {
                    Console.WriteLine("I'm sorry, you need to pick again!");
                }
                else
                {
                    Console.WriteLine("You name is:" + babyboyNames[b]);
                    finished = true;
                }
                Console.ReadLine();
            }

            int[] timeforSchool = { 0, 1, 2, 3, 4, 5 };
            bool schfinished = false;
            while (!schfinished)
            {
                Console.WriteLine("What age (between 0 and 5) do you think preschool should start?");
                int s = Convert.ToInt32(Console.ReadLine());

                if (s > 5)
                {
                    Console.WriteLine("I'm sorry, that age is not an option, please pick again");
                }
                else
                {
                    Console.WriteLine("The age you chose was:" + timeforSchool[s]);
                    schfinished = true;
                }
                Console.ReadLine();
            }

            List<string> favoriteBondMovie = new List<string>();

            favoriteBondMovie.Add("");
            favoriteBondMovie.Add("Quantum of Solace");
            favoriteBondMovie.Add("Tomorrow Never Dies");
            favoriteBondMovie.Add("GoldenEye");
            favoriteBondMovie.Add("Dr.No");
            favoriteBondMovie.Add("GoldFinger");
            bool bondfinish = false;
            while(!bondfinish)
            {
                Console.WriteLine("Ok, so we have a list of the TOP FIVE Bond movies, pick a number and see what movie it is!");
                int bondFilm = Convert.ToInt32(Console.ReadLine());

                if (bondFilm > 5)
                {
                    Console.WriteLine("That is not an option,please try again!");
                }
                else
                {
                    Console.WriteLine("Drum Roll Please...................Your movie is:" + favoriteBondMovie[bondFilm]);
                    bondfinish = true;
                }
                Console.ReadLine();
            }
        }
    }
}


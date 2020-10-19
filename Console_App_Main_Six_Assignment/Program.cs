using System;
using System.Collections.Generic;

namespace Console_App_Main_Six_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // CONSOLE APP ASSIGNMENT PART ONE
            // This first section asks the user to assign a class to the students, then the for loop
            // will cycle through them and then write to the console their names with the course from the user

            string[] studentNames = { "Fred", "Ryan", "Kijo", "Mikey", "Bob" };

            Console.WriteLine("I want you to assign a course to my new students, go ahead, type a class name:");
            string course = Console.ReadLine();

            for (int j = 0; j < studentNames.Length; j++)
            {
                if (studentNames[j] != " ")
                {
                    Console.WriteLine("Perfect! You assigned " + studentNames[j] + " to the: " + course + " course");
                }
            }
            Console.ReadLine();

            //****************BREAK TO NEXT ASSIGNMENT********************************

            //CONSOLE ASSIGNMENT TWO

            // This will have our start point at 1, then count to 50, 
            // the first while statement just says while it's true, add 1
            // since there is no dedicated top, it keeps going. 
            // The second  while fixes this by implementing restrictions
            // at the while loop.

            int numStart = 1;
            Console.WriteLine("Lets count to 50, hit enter to start!");
            Console.ReadLine();

            //while(true)
            // {
            //     Console.WriteLine(numStart++);
            // }

            while (numStart <= 50)
            {
                Console.WriteLine(numStart++);

            }
            Console.ReadLine();

            //********************BREAK TO NEXT ASSIGNMENT*******************

            // CONSOLE ASSIGNMENT THREE

            //  rideHeight is going to take the users height,
            // then were going to make use of the < operator 
            //so if they are 47 and lower, they will be to short
            // however making use of the <= means that if they
            // are 48, they can ride.

            Console.WriteLine("How tall are you?");
            int rideHeight = Convert.ToInt32(Console.ReadLine());

            if (rideHeight < 48)
            {
                Console.WriteLine("You just to short, move it along");
            }

            else if (rideHeight <= 48)
            {
                Console.WriteLine("You are just tall enough");
            }
            Console.ReadLine();

            //**********************BREAK TO NEXT ASSIGNMENT**********

            // CONSOLE ASSIGNMENT FOUR

            // We created a unique list of strings here (each their own name)
            // We then ask the user to pick a string from the list and then assign that string
            // to a variable.Using the Switch Case loop we can run a specific line that shows 
            // what index the user has picked based on the actual item in the list. We also 
            // create a loop to where if they do pick an item NOT on the list, it will give them the 
            // option to roll back around and try again. As soon as they pick the correct string, the program ends

            List<string> carChoices = new List<string>() { "Ford", "Chevy", "Mazda", "Nissan", "Dodge" };

            Console.WriteLine("I've got a few models on my lot, which model are you looking to buy?");
            string modelPicked = Console.ReadLine();
            bool desiredModel = modelPicked == "";


            do
            {
                switch (modelPicked)
                {
                    case "Ford":
                        Console.WriteLine("\nIndexOf(" + modelPicked + "): {0}", carChoices.IndexOf(modelPicked));
                        desiredModel = true;
                        break;

                    case "Mazda":
                        Console.WriteLine("\nIndexOf(" + modelPicked + "): {0}", carChoices.IndexOf(modelPicked));
                        desiredModel = true;
                        break;

                    case "Chevy":
                        Console.WriteLine("\nIndexOf(" + modelPicked + "): {0}", carChoices.IndexOf(modelPicked));
                        desiredModel = true;
                        break;

                    case "Dodge":
                        Console.WriteLine("\nIndexOf(" + modelPicked + "): {0}", carChoices.IndexOf(modelPicked));
                        desiredModel = true;
                        break;

                    default:
                        Console.WriteLine("I'm sorry, I do not seem to have that specific model on my lot. Maybe something else looks good?");
                        modelPicked = Console.ReadLine();
                        break;

                }

            }
            while (!desiredModel);

            Console.ReadLine();

            //***************************BREAK TO NEXT ASSIGNMENT***************

            // CONSOLE ASSIGNMENT FIVE
            // This takes a list of cars
            // then cycles through them and prints them to the screen, this then 
            // iterates through the list and if they chose the car on the list it will
            // show that indices place, and then if they choose one that is 
            // not on the list, it will inform them that it's not a valid option.
            List<string> favCar = new List<string>() { "350Z", "370Z", "FoxBody", "350Z" };

            Console.WriteLine("Pick your favorite car from the list\n");
            foreach (string i in favCar)
            {
                Console.WriteLine(i);
            }
            string favPicked = Console.ReadLine();

            for (int i = 0; i < favCar.Count; i++)
            {
                if (favPicked == favCar[i])
                {
                    Console.WriteLine("Match found at :" + i);
                }
                else
                {
                    Console.WriteLine("That is not a valid option");
                }
            }
            Console.ReadLine();


            //**********************BREAK TO NEXT ASSIGNMENT******************

            //CONSOLE ASSIGNMENT SIX

            // I created a list here of "favGames" that has two identical strings, I first created a foreach loop to
            // cycle through it and then display it on the screen, There is a secondary 
            // foreach loop that will compare the string(s) and then display if there is a 
            // match so the output should be a display of the list and then 
            // the string declaring which string has an identical match.

            List<string> favGames = new List<string>() { "Mario", "Zelda", "Kirby", "DigDug", "Mario" };
            foreach (string i in favGames)
            {
                Console.WriteLine(i);
            }
            //Next section will iterate and then display the matched duplicated string
            foreach (string s in favGames)
            {
                foreach (string s2 in favGames)
                {
                    if (s.Equals(s2))
                        Console.WriteLine("\n{0}  is in here twice", s);
                    Console.ReadLine();
                }

            }

        }
    }
}

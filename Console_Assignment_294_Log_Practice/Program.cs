using System;
using System.IO;

namespace Console_Assignment_294_Log_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //This will ask the user for a number and then will print that answer (userinput) to the .txt ile in the path.
            Console.WriteLine("Please enter a number");
            String userInput = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Ryan\Desktop\Basic_C#_Programs\log\log.txt", userInput);

            // This next section will take the contents of that .txt file and then print them back to the user.
            //string userInput = File.ReadAllText(@"C:\Users\Ryan\Desktop\Basic_C#_Programs\log\log.txt");
            //Console.WriteLine(userInput);
            //Console.ReadLine();
        }
    }
}

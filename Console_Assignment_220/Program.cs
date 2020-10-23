using System;
using System.Diagnostics.CodeAnalysis;

namespace Console_Assignment_220
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();

            Console.WriteLine("Please enter two number, one at a time");
            int userInput1 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter your second number, or you can leave this blank");
            var userinput2 = Console.ReadLine();



            if (userinput2 != "")
            {
                int ui2 = Convert.ToInt32(userinput2);
                Console.WriteLine(a.Addition(userInput1, ui2));
            }
            else
            {
                Console.WriteLine(a.Addition(userInput1));
            }
            Console.ReadLine();
            

        }
    }
}

using System;

namespace Class_Assignment_216
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want to do the operation on?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}  {1}  {2}", MyClass.subNum(userInput), MyClass.sumNum(userInput), MyClass.multNum(userInput));
            Console.ReadLine();
        }
    }
}

using System;

namespace Console_Assignment_221
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();



            //passing two numbers
            a.Addition(50, 50);
            Console.ReadLine();

            //specify by name
            a.Addition(x:75, y:10);
            Console.ReadLine();

            
        }
    }
}

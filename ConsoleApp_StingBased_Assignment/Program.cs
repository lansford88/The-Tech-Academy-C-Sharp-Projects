using System;
using System.Text;

namespace ConsoleApp_StingBased_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string f_Name = "Ryan";
            string last_Name = " Patrick";
            string dreamJob = " To CREATE Unity Assets and work with a development team on a game!";

            Console.WriteLine(f_Name + last_Name + dreamJob);
            Console.ReadLine();

            Console.WriteLine(f_Name.ToUpper());
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Ryan\n");
            sb.Append("My last name is Parick\n");
            sb.Append("My goal for this course is to learn and then build my own projects!");
            

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}

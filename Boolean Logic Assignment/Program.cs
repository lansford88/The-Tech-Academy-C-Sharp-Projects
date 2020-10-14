using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int ageVar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Please answer True or False.");
            bool duiVar = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int ticketVar = Convert.ToInt32(Console.ReadLine());

            bool qualAnswer = ageVar >= 15 && duiVar == false  && ticketVar <= 3;
            Console.WriteLine("Qualified?\n"  + qualAnswer);
            Console.ReadLine();

        }
    }
}

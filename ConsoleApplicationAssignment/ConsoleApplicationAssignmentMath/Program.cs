using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignmentMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number, I will multiply it by 50!");
            int numMult  = Convert.ToInt32(Console.ReadLine());
            double multResult = numMult * 50;
            Console.WriteLine(multResult);
            Console.ReadLine();

            Console.WriteLine("Please enter a number, I will add 25 to it");
            int numAdd = Convert.ToInt32(Console.ReadLine());
            int addResult = numAdd + 25;
            Console.WriteLine(addResult);
            Console.ReadLine();

            Console.WriteLine("Please Enter a number, I will divide it by 12.5!");
            int numDiv = Convert.ToInt32(Console.ReadLine());
            double divResult = numDiv / 12.5;
            Console.WriteLine(divResult);
            Console.ReadLine();

            Console.WriteLine("Please enter a number and I'll tell you if it's greater than 50!");
            int numGreat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numGreat > 50);
            Console.ReadLine();

            Console.WriteLine("Please enter a number and i'll divide it by 7 and i'll give you the remainder!");
            int modNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(modNum % 7);
            Console.ReadLine();
            
            
        }
    }
}

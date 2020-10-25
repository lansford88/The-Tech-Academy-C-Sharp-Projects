using System;

namespace Console_Assignment_Struct_260
{
    class Program
    {
        static void Main(string[] args)

        {
            Number fullCost = new Number();
            fullCost.Amount =140.00m;

            Console.WriteLine(fullCost.Amount);
            Console.ReadLine();
        }

         struct Number
        { 
        
        
            public decimal Amount { get; set; }
        }
    }
}

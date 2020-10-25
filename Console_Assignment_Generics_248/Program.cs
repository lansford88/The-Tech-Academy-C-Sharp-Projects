using System;
using System.Collections.Generic;

namespace Console_Assignment_248
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> employeeItems = new Employee<string>();                // Instantiates the Employee class and the required generic parameter
            
            employeeItems.Things = new List<string>() { "Laptop", "Notebook", "IdBadge" };

            foreach (string i in employeeItems.Things) 
            {
                Console.WriteLine(i);
            }
            


            Employee<int> empItemAmount = new Employee<int>();
            empItemAmount.Things = new List<int>() { 1, 5, 1 };

            foreach (int e in empItemAmount.Things)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
            
            
        }
    }
}

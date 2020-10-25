using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Console_Assignment_265_Lambda_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // NORMAL CREATE LIST AND THEN USE FOREACH TO SEP OUT JOE
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { Id = 2, firstName = "Joe", lastName = "Black" });
            empList.Add(new Employee() { Id = 4, firstName = "Jason", lastName = "Stathom" });
            empList.Add(new Employee() { Id = 6, firstName = "Jack", lastName = "Black" });
            empList.Add(new Employee() { Id = 8, firstName = "Dwayne", lastName = "Johnson" });
            empList.Add(new Employee() { Id = 10, firstName = "Britney", lastName = "Spears" });
            empList.Add(new Employee() { Id = 12, firstName = "Justin", lastName = "Bieber" });
            empList.Add(new Employee() { Id = 14, firstName = "William", lastName = "Wallace" });
            empList.Add(new Employee() { Id = 16, firstName = "Joe", lastName = "Shmo" });
            empList.Add(new Employee() { Id = 18, firstName = "Lewis", lastName = "Litt" });
            empList.Add(new Employee() { Id = 20, firstName = "Harvey", lastName = "Spector" });
            //List<Employee> joeList = new List<Employee>();

            //foreach (var data in empList)
            //{
            //    if (data.firstName == "Joe")
            //    {
            //        joeList.Add(data);
            //    }
            
            //foreach (var data in joeList)
            //{
            //    Console.WriteLine(data.firstName + " " + data.lastName);
            //}
            //Console.ReadLine();
            //*************************************************************************************
            // EXAMPLE OF SAME ABILITY WITH LAMBDA FUNCTIONS

             var joeList = empList.Where(x => x.firstName.Contains("Joe"));

            foreach (var data in joeList)
            {
                Console.WriteLine(data.firstName + " " + data.lastName);
            }
            Console.ReadLine();
            //**********************************
            var idNum = empList.Where(x => x.Id > 5);

            foreach (var data in idNum)
            {
                Console.WriteLine("These employees have id greater than 5: " + data.firstName + " " + data.lastName);
            }
            Console.ReadLine();






        }


        public class Employee
        { 
            public string firstName { get; set; }
            public string lastName { get; set; }
            public int Id { get; set; }
        }

    }
}

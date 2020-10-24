using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Assignment_229
{
    public class Person
    {

        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

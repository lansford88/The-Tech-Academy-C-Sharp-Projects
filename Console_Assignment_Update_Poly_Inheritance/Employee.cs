using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Assignment_237
{
    class Employee  : Person, IQuittable
    {
        public override void SayName()
        {
            throw new NotImplementedException();
        }

        public void Quit(Employee employee)
        {
            Console.WriteLine("I'm Out");
        }
    }
}

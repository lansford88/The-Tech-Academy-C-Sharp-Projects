using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Assignment_245
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            throw new NotImplementedException();
        }

        public void Quit(Employee employee)
        {
            Console.WriteLine("I'm Out");
        }


        // Operator Overload ("==") Requires you to have a ("!=") as well. 
        public static bool operator ==(Employee employee, Employee employee1)   
        {
            
            return employee1.Id == employee.Id;
        }

        public static bool operator !=(Employee employee, Employee employee1)
        {
           
            return employee1.Id != employee.Id;
        }

       

       public int Id { get; set; }
    }
}

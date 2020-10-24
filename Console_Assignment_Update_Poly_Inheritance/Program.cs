using System;

namespace Console_Assignment_237
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee employee = new Employee(); // Instantiate Employee Object
            employee.firstName = "Sample";
            employee.lastName = "Student";

            //employee.SayName();

            IQuittable quittable = new Employee();      //Use Polymorphism after creating object of IQuitable since it is inherited I could use it on the object Employee.
            employee.Quit(employee);
            Console.ReadLine();
        }
    }
}

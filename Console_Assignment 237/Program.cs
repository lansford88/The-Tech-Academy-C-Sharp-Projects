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

            employee.SayName();
        }
    }
}

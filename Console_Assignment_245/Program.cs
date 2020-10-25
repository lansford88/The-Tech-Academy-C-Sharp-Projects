using System;

namespace Console_Assignment_245
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee employee = new Employee(); // Instantiate Employee Object
            //employee.firstName = "Sample";
            //employee.lastName = "Student";

            //employee.SayName();

            //IQuittable quittable = new Employee();      //Use Polymorphism after creating object of IQuitable since it is inherited I could use it on the object Employee.
            //employee.Quit(employee);
            //Console.ReadLine();
            
            // Instance of employee is already created above
            // Create instance of employee1 since that is what were going to compare
            Employee employee1 = new Employee();
            employee.Id = 4;                                                                        //Assign each employee and id which since that is the property in our Employee class we can use employee.Id
            employee1.Id = 5;
            bool compareEmp = employee == employee1;                        //The comparison method in Employee class returns employee.Id, since we assigned it here, we just need to create
            bool compareEmp1 = employee != employee1;                       // the bool variables that compare each employee
            Console.WriteLine(compareEmp);
            Console.WriteLine(compareEmp1);
            Console.ReadLine();
        }
    }
}

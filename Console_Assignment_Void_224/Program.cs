using System;

namespace Console_Assignment_Void_224
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();      // instantiate the class 
            //CREATE VOID WITH OUTPUT INTEGER

            Console.WriteLine("Pick a number : ");
            int userinput1 = Convert.ToInt32(Console.ReadLine());
            a.divNum(userinput1);
            
            
            // CREATE OUTPUT PARAMETERS
            int num1;   //create a local variable

            a.OutPut(out num1); // calls a function to get the value

            Console.WriteLine("User in put divided by 2 : {0}", num1 / 2);
            Console.ReadLine();

            // OVERLOAD A METHOD WITH A STATIC DECLARED CLASS
            int numeralA = OverLoad.AddNum(5, 5);
            double numeralB = OverLoad.AddNum(10.5, 10.5);

            Console.WriteLine("Integer : " + numeralA);
            Console.WriteLine("Double : " + numeralB);
            Console.ReadLine();
         }
    }
}

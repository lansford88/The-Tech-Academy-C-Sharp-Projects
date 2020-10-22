using System;


namespace Class_Assignment_219
{
    public class Program
    {
        public static void Main(string[] args)
        {
           MyClass myClass = new MyClass();

            int num1 = MyClass.Addition(25);
            double num2 = MyClass.Addition(1.5);
            string num3 = MyClass.Addition("10");        

            Console.WriteLine("Int :" + num1);
            Console.WriteLine("Double :" + num2);
            Console.WriteLine("String:" + num3);
            
            Console.ReadLine();
         }
        
    }
}

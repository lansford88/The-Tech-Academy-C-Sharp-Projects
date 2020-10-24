using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Assignment_Void_224
{
    class MyClass
    {

        public void divNum(int x)
        {
            Console.WriteLine(x / 2);
        }

        public void OutPut(out int x)
        {
            Console.WriteLine("Enter a number please: ");
            x = Convert.ToInt32(Console.ReadLine());
        }

    }
}

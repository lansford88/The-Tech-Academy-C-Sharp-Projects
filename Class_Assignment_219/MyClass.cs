using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Assignment_219
{
    public class MyClass
    {
        public static int Addition(int num1)
        {
            return num1 + 50;
        }

        public static double Addition(double num2)
        {
            return num2 *  50.5;
        }
        public static string Addition(string num3)
        {
            int x = Convert.ToInt32(num3);
            int y = (x * 2);
            num3 = y.ToString();
           return num3;
        }
    }
}

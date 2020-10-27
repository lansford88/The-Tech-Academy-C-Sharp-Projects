using System;

namespace Console_Assignment_310_Const_Var_ChainPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // var variable
            var newRideA = "CB";

            //const variable
            const string myCatchPhrase = "Gunna be dumb, gotta be tough";


            //Use of Constructor Chain.
            MotorCycle newBike = new MotorCycle("CB750K");
            newBike.model = "Honda";

            Console.WriteLine("I just got a new {0} {1} ", newBike.color,newBike.model);
            Console.ReadLine();
        }
    }
}

using System;

namespace Console_Assignment_314
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int years = DateTime.Now.Year;

                Console.WriteLine("Please enter your age");
                int ageEntered = Convert.ToInt32(Console.ReadLine());
                if (ageEntered < 0)
                {
                    throw new NegativeException();
                }

                if (ageEntered == 0)
                {
                    throw new ZeroException();
                }



                int yearBorn = years - ageEntered;
                Console.WriteLine(yearBorn);
                Console.ReadLine();
            }
            catch (NegativeException)
            {
                Console.WriteLine("I'm sorry, i'm not sure your age is negative.");
                Console.ReadLine();
                return;
            }
            catch (ZeroException)
            {
                Console.WriteLine("I've heard that babies are learning a bit quicker but 0, really?");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("I'm not sure that is an age.");
                Console.ReadLine();
                return;
            }


        }

    }
}
using System;

namespace Console_App_Assignment_DO_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let us test your mental prowess! What color am I thinking of?");
            string colorGuess = Console.ReadLine();
            bool colorGuessed = colorGuess == "Green";

            do
            {
                switch (colorGuess)
                {
                    case "Blue":
                        Console.WriteLine("You guessed Blue, that is close but no cigar. Try again!");
                        Console.WriteLine("Let us test your mental prowess! What color am I thinking of?");
                        colorGuess = Console.ReadLine();
                        break;

                    case "Red":
                        Console.WriteLine("You guessed Red, that is close but no cigar. Try again!");
                        Console.WriteLine("Let us test your mental prowess! What color am I thinking of?");
                        colorGuess = Console.ReadLine();
                        break;

                    case "Yellow":
                        Console.WriteLine("You guessed Yellow, that is close but no cigar. Try again!");
                        Console.WriteLine("Let us test your mental prowess! What color am I thinking of?");
                        colorGuess = Console.ReadLine();
                        break;
                    case "Purple":
                        Console.WriteLine("You guessed Purple, that is close but no cigar. Try again!");
                        Console.WriteLine("Let us test your mental prowess! What color am I thinking of?");
                        colorGuess = Console.ReadLine();
                        break;

                    case "Green":
                        Console.WriteLine("You guessed Green, YOU GOT IT!!");
                        colorGuessed = true;
                        break;

                    default:
                        Console.WriteLine("You guessed a color that is close but no cigar. Try again!");
                        Console.WriteLine("Let us test your mental prowess! What color am I thinking of?");
                        colorGuess = Console.ReadLine();
                        break;
                }
            }
            while (!colorGuessed);

            Console.Read();

        }
    }
}

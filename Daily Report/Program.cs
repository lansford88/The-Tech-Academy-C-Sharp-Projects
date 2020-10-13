using System;


namespace Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Report");
            

            Console.WriteLine("\nWhat is your name?");
            string nameVar = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string courseVar = Console.ReadLine();

            Console.WriteLine("What page Number?");
            string pageNum = Console.ReadLine();
            int pageNumber = Convert.ToInt32(pageNum);

            Console.WriteLine("Do you need help with Anything? Please answer True or False.");
            bool answer = true;
            string assistVar = Convert.ToString(answer);
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            string experienceVar = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedbackVar = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int hoursReal = Convert.ToInt32(hoursStudied);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        
        }
    }
}

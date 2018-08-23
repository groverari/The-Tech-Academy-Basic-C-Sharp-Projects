using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("\n\nWhat Course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What Page are you on?");
            string page = Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Answer True or False");
            bool help = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Would you like to share some positive experience. Be specific");
            string positive = Console.ReadLine();
            Console.WriteLine("Any other Feedback?");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many Hours did you study today");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thanks for your answers An instuctor will shortly respond to this. Have a great day!");
        }
    }
}

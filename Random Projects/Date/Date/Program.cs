using System;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Enter how many hours you would like to add");
            double hours = Convert.ToInt32(Console.ReadLine());
            DateTime date = DateTime.Now;
            Console.WriteLine(date.AddHours(hours));
            Console.ReadLine();

        }
    }
}

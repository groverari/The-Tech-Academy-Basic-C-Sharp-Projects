using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("\n\n\nPerson 1");
            Console.WriteLine("Hourly Rate?");
            int rate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours");
            int hours1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n\nPerson 2");
            Console.WriteLine("Hourly Rate?");
            int rate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours");
            int hours2 = Convert.ToInt32(Console.ReadLine());
            int annual1 = rate1 * hours1 * 52;
            int annual2 = rate2 * hours2 * 52;
            Console.WriteLine("Annual Salary of Person 1: " + annual1);
            Console.WriteLine("Annual Salary of Person 2: " + annual2);

            bool more = annual1 > annual2;

            Console.WriteLine("Does person 1  make more money than person 2? " + more);

        }
    }
}

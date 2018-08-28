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
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("Package Weight?");
            decimal weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Package Width?");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Package Height?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Package length?");
            int length  = Convert.ToInt32(Console.ReadLine());


            if (weight > 50)
                Console.WriteLine("Package too big to be shipped via Package Express.");
            else {
                decimal price = (width + length + height) *weight/100;
                Console.WriteLine("Your total for this package will be: " + price);
            }
            Console.Read();

        }
    }
}

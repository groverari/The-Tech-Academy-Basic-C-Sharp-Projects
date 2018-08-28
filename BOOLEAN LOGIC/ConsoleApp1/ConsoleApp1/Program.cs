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
            Console.WriteLine("What is Your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Yes or No.");
            string foo = Console.ReadLine();
            Console.WriteLine("How many speeding Tickets have you had?");
            int tick = Convert.ToInt32(Console.ReadLine());
            bool dui = false ;
            if (foo.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
                dui = true;
            bool qual = age > 15 && !dui && tick <= 3;
            Console.WriteLine("Are you qualified?  " + qual);
   
            Console.Read()
        }
    }
}

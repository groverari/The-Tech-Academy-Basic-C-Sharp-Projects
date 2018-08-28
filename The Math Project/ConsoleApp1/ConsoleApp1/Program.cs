using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            long num = Convert.ToInt32(Console.ReadLine());
            num *= 50;
            Console.WriteLine("Your number times 50 is equal to: " + num);
            Console.WriteLine("Enter another number");
            num = Convert.ToInt32(Console.ReadLine());
            num += 25;
            Console.WriteLine("Your number plus 25 is equal to: " + num);
            Console.WriteLine("Enter another number");
            double num1 = Convert.ToInt32(Console.ReadLine());
            num1 = num1 / 12.5;
            Console.WriteLine("Your number diveded by 12.5 is equal to: " + num1);
            Console.WriteLine("Enter another number");
            num = Convert.ToInt32(Console.ReadLine());
            bool foo = num > 50;
            Console.WriteLine("Your number is bigger than 50: " + foo);
            Console.WriteLine("Enter another number");
            num = Convert.ToInt32(Console.ReadLine());
            num %= 7;
            Console.WriteLine("Your number when divided by 7 has a remainder of : " + num);
            Console.Read();
        }
    }
    }

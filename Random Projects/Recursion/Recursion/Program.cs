using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("How many Fibbonacci Numbers would you like me to call");
        //    int num3 = Convert.ToInt32(Console.ReadLine());
        //    Fibbonacci(num3);
        //    Console.ReadLine();
        //}


        //public static void Fibbonacci(int num3)
        //{
        //    int num1 = 1;
        //    Console.WriteLine("1\n1");
        //    int num2 = 1;
        //    int nextNum1;
        //    int nextNum2;
        //    int count = 0;
        //    while (count < num3 - 2)
        //    {
        //        Fibbonacci(num1, num2, out nextNum1, out nextNum2);
        //        num1 = nextNum1;
        //        num2 = nextNum2;
        //        count++;

        //    }

        //}
        //public static void Fibbonacci(int num1, int num2, out int nextNum1, out int nextNum2)
        //{

        //    nextNum1 = num2;
        //    nextNum2 = num2 + num1;

        //    Console.WriteLine(nextNum2);

        //}


static void Main(string[] args)
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Please enter a number");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" #" + Fibonacci(number));
            }
            Console.ReadLine(); 
        }

        public static int Fibonacci(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(number - 2) + Fibonacci(number - 1);
            }
        }





    }
}

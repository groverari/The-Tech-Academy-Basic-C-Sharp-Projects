using System;

namespace Stucts
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number() { Amount = 35.20m };
            Console.WriteLine(num.Amount);
        }
    }
}

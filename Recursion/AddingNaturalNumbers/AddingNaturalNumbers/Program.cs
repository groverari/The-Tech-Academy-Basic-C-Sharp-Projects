using System;

namespace AddingNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter A number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(addNum(num));
            Console.ReadLine();
        }

        public static int addNum(int num)
        {
            if (num > 1)
                return num + addNum(num - 1);
            else
                return 1;
        }
    }
}

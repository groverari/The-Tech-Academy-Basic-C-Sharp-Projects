using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            doSomething(num2, out num2);
            Console.WriteLine(num2);
            Console.ReadLine();
        }
        public int doSomething(int num1)
        {
            return num1 / 2;
        }
        public static void doSomething(int num1, out int num2)
        {
            num2 = num1 / 2; 
        }
    }
}

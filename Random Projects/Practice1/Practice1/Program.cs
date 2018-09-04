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
            int num2;
            
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Foo.doSomething(num1, out num2);
            Console.WriteLine(num2);
            Console.ReadLine();
        }
    }
}

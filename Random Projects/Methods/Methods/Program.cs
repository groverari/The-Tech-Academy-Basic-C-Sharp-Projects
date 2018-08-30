using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation foo = new Operation();
            foo.doSomething(1, 2);
            foo.doSomething(num1: 2, num2: 3);
            Console.ReadLine();
        }
    }
}

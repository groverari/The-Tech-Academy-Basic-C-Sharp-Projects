using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegerMath foo = new IntegerMath();

            Console.WriteLine(foo.maths(1));
            Console.WriteLine(foo.maths(1.67m));
            Console.WriteLine(foo.maths("3"));
        }
    }
}

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
            int age = 2;
            bool oldEnough= age>18;
            while (!oldEnough) {
                age += 1;
            }

            age = 3;

            do
            {
                age += 1;
            } while (!oldEnough);

        }
    }
}

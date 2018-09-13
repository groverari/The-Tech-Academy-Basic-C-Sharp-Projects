using System;
using System.Collections.Generic;
using System.Text;

namespace Practice2
{
    class number
    {
        public number(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);

        }
        public number(int num1) : this(num1, 0)
        {

        }
    }
}

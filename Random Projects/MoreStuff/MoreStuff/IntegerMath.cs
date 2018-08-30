using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreStuff
{
    class IntegerMath
    {
        public int maths(int num1)
        {
            return num1 + 43;
        }
        public int maths(decimal num1)
        {
            return Convert.ToInt32(  num1 * 43);
        }
        public int maths(string s1)
        {
            return Convert.ToInt32(s1) + 53;
        }
    }
}

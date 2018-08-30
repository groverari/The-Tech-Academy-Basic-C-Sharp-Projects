using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number would you like to use?");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DivideBy3(num));
            Console.WriteLine(MultiplyByThree(num));
            Console.WriteLine(Add23(num));
            Console.ReadLine();
        }

        public static int DivideBy3(int num) {
            return num / 3;
        }
        public  static int MultiplyByThree(int num)
        {
            return num*3;
        }
        
        public static int Add23(int num)
        {
            return num + 23;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Maths foo = new Maths();
            try
            {
                
                Console.WriteLine("Input Another Number. This is optional");
                int num2 = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine(foo.doThis(num1, num2));

            }
            catch(Exception ex)
            {
                Console.WriteLine("The Second Number automatically set to 4");
                Console.WriteLine(foo.doThis(num1));
            } 
            Console.ReadLine();

        }
    }
}
    
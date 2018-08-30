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
            try {
                List<int> nums = new List<int>();
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                    nums.Add(rnd.Next(20));
                Console.WriteLine("Enter a number that each number in the list will be divided by ");
                int div = Convert.ToInt32(Console.ReadLine());
                foreach (int num in nums)
                    Console.WriteLine(num + " divided by " + div + " equals " + (num / div));
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("please dont divide by zero");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}

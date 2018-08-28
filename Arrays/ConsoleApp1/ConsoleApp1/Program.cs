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
            string[] strings = new string[] { "jesse", "mike", "ariesh" };
            int[] nums = new int[] { 5, 4, 3, 2, 1, 3, 54 };
            List<string> s1 = new List<string>();
            s1.Add("hello");
            s1.Add("world");
            s1.Add("!");

            Console.WriteLine("Enter an index");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= strings.Length)
                Console.WriteLine("Thats an invalid index");
            else
                Console.WriteLine(strings[num]);

            Console.WriteLine("Enter an index");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= nums.Length)
                Console.WriteLine("Thats an invalid index");
            else
                Console.WriteLine(nums[num]);

            Console.WriteLine("Enter an index");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 3)
                Console.WriteLine("Thats an invalid index");
            else
                Console.WriteLine(s1[num]);
            Console.Read();

        }
    }
}

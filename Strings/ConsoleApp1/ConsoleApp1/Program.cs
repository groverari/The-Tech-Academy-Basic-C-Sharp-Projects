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
            string s1 = "Hello ";
            string s2 = "World ";
            string s3 = "!";
            s1 += s2 + s3;
            Console.WriteLine(s1);
            Console.WriteLine(s1.ToUpper());
            StringBuilder sb = new StringBuilder();
            sb.Append("Welcome to McDonald's");
            sb.Append(" May I take your order");
            sb.Append(". Thank you for your patientce.");
            Console.WriteLine(sb);
            Console.Read();
        }
    }
}

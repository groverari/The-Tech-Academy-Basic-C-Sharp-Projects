using System;
using System.Text.RegularExpressions;

namespace Basic_Password_Verifacation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Grover99!";
            string pattern = @"([0-9]+)([A-Z]+)(.{8,15})([a-z])";
            Match m = Regex.Match(input, pattern);
            Console.WriteLine(m.Success);
            Console.ReadLine();
        }
    }
}

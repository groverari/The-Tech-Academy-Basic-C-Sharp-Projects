using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\TechAcademy\The-Tech-Academy-Basic-C-Sharp-Projects\Random Projects\FileIO\log.txt", true))
            {
                file.WriteLine(num1);
            }
            Console.WriteLine("\n\n\n\n");
            string[] text = File.ReadAllLines(@"C:\TechAcademy\The-Tech-Academy-Basic-C-Sharp-Projects\Random Projects\FileIO\log.txt");
            foreach (string s1 in text)
            {
                Console.WriteLine(s1);
            }
            Console.ReadLine();
        }
    }
}

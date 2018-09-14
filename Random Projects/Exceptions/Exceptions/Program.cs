using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your age");
                int age = Convert.ToInt32(Console.ReadLine());
                if(!(age > 0))
                {
                    throw new AgeException();
                }
                int yearBorn = 2018 - age;
                Console.WriteLine(yearBorn);
                Console.ReadLine();
            }
            catch (AgeException)
            {
                Console.WriteLine("Why You Always Lying");
                Console.ReadLine();
            }
            
        }
    }
}

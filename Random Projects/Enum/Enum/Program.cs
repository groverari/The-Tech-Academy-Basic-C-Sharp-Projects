using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a day of the week:");
                string input = Console.ReadLine();
                bool isEnum = System.Enum.IsDefined(typeof(Days), input);
                if (!isEnum)
                {
                    throw new NotEnumException();
                }
                else
                {
                    Console.WriteLine("That is a day of the week");
                }
            }
            catch (NotEnumException)
            {
                Console.WriteLine("That's not a day of the week!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("The following exception ocurred: " + ex.Message);
            } 
            Console.ReadLine();
        }
    }
    public enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}

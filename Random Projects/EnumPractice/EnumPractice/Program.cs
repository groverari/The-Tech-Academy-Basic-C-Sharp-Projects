using System;

namespace EnumPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Enter a day of the week");
                string input = Console.ReadLine();
            DaysOfTheWeek day;
                
                bool isTrue = Enum.IsDefined(typeof(DaysOfTheWeek), input);
            if (!isTrue)
            {
               

            }
            else day = DaysOfTheWeek.Monday;
                
           try
            {
                if (!isTrue)
                    Console.WriteLine(day);

            }
            catch (Exception x)
            {
                Console.WriteLine("Please Enter an actual day");
            }
            Console.ReadLine();

    }    }
    
    public enum DaysOfTheWeek
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

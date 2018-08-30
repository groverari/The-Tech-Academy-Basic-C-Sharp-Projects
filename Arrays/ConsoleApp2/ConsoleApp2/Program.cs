using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s1 = new string[4];
            for (int i = 0; i < s1.Length; i++)
            {
                Console.WriteLine("enter some text");
                s1[i] = Console.ReadLine();
            }
            for (int i = 0; i < s1.Length; i++)
            {
                Console.WriteLine(s1[i]);
            
            }
            int num = 0;
            while (num < 3)
                num++;

            num = 0;
            while (num <= 3)
                num++;
            List<string> strings = new List<string>();
            strings.Add("banana");
            strings.Add("tomato");
            strings.Add("apple");
            strings.Add("carrot");
            strings.Add("pear");
            Console.WriteLine("Guess What vegetable is in the array?");
            string guess = Console.ReadLine();
            bool attempt = false;
            //foreach (string foo in strings) {
            //    if (guess == foo)
            //    {
            //        Console.WriteLine("You guessed right. The Index was: "+ i);
            //        attempt = true;
            //    }
            //}
            //if (!attempt)
            //    Console.WriteLine("You were wrong");

            do
            {
                int i = 0;
                if (guess == strings[i])
                {
                    Console.WriteLine("you guessed right. the index was: " + i);
                    attempt = true;
                }
                i++;
                if(i == strings.Count)
                {
                    Console.WriteLine("You didn't get the answer :(");
                    attempt = true;
                }
            } while (!attempt);


            List<string> random = new List<string>;
            random.Add("Justin");
            random.Add("Justin");
            random.Add("Blake");
            random.Add("John");
            random.Add("Austin");
            random.Add("Tim");

            Console.WriteLine("Guess What vegetable is in the array?");
            guess = Console.ReadLine();
            attempt = false;
            for(int i = 0; i< random.Count; i++)
            {
                if(guess == random[i])
                {
                    Console.WriteLine("You guessed right. The Index was: " + i);
                    attempt = true;
                }
                    
            }
            if(!attempt)
                Console.WriteLine("You were wrong");
            attempt = false;
            foreach(string foo in random)
            {
                for (int i = 0; i < random.IndexOf(foo); i++)
                    if (foo == random[i])
                    {
                        Console.WriteLine(foo+" appears before in the list.");
                        attempt = true;
                    }
            }
            if (!attempt)
                Console.WriteLine("It doesn't appear before in the list");
        }
        }
    }
}

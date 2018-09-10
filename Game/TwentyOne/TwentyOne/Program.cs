using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Lets start by telling me your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("Hello, " + playerName +" how much money will you be playing with today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would you like to play a game of 21 right now");
            string answer = Console.ReadLine().ToLower();
            if(answer == "yes"||answer =="yeah"|| answer == "y"||answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank You for playing");
            }
            Console.WriteLine("Feel free to look around. By for now");
            Console.ReadLine();

        }
    }
}

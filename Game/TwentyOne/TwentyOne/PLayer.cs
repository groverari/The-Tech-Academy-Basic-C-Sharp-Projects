using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool stay { get; set; }

        public Player(string playerName, int bank)
        {
            Hand = new List<Card>();
            Name = playerName;
            Balance = bank;
        }
        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator-(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
        public bool Bet(int amount)
        {
           if(Balance - amount < 0)
            {
                Console.WriteLine("You don't have that much money");
                return false;
            }
            return true;
        }

    }
    public enum Suit
    {
        Clubs, Diamonds, Hearts, Spades
    }
}

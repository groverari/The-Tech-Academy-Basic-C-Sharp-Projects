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
            Deck deck = new Deck();
            

        }

        public static Deck Shuffle(Deck deck, int times = 1)
        {
            List<Card> temp = new List<Card>();
            Random rnd = new Random();
            for(int i = 0; i<times; i++)
            {
                while(deck.Cards.Count > 0)
                {
                    int rndIndex = rnd.Next(deck.Cards.Count);
                    temp.Add(deck.Cards[rndIndex]);
                    deck.Cards.RemoveAt(rndIndex);
                }
            }
            deck.Cards = temp;
            return deck;
        }
    }
}

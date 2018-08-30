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
            Deck deck = new Deck();
            Shuffle(deck);
            foreach (Card card in deck.Cards)
                Console.WriteLine(card.Face + " of " + card.Suit);
            
            


        }

        public static Deck Shuffle(Deck deck)
        {
            List<Card> tempList = new List<Card>();
            Random rnd = new Random();

            while (deck.Cards.Count > 0) {
                int rndIndex = rnd.Next(0, deck.Cards.Count);
                tempList.Add(deck.Cards[rndIndex]);
                deck.Cards.RemoveAt(rndIndex);
            }

            deck.Cards = tempList;
            return deck;
        }
    }
}

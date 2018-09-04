using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public List<Card> Cards { get; set; } 
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Hearts","Diamonds", "Clubs", "Spades" };
            List<string> Faces = new List<string>()
            {
                "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
                "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };
            foreach(string suit in Suits)
            {
                foreach(string face in Faces)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);       

                }
            }
        }
    }
}

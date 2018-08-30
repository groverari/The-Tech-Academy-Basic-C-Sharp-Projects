using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Deck
    {
        public List<Card> Cards { get; set; }= new List<Card>(); 

        public Deck()
        {
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach(string suit in Suits)
            {
                foreach(string face in Faces)
                {
                    Card card = new Card();
                    card.Face = face;
                    card.Suit = suit;
                    Cards.Add(card);

                }
            }
        }
    }
}

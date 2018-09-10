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
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++) {
                    Card c1 = new Card();
                    c1.face = (Face)i;
                    c1.suit = (Suit)j;
                    Cards.Add(c1);


                }

            }
            
        }
    }
}

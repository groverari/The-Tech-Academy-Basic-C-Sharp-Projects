using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public struct Card
    {
        public  Suit suit { get; set; }
        public Face face { get; set; }
        public override string ToString()
        {
            return string.Format("Your cards are {0} of {1}", face, suit);
        }

    }
    public enum Suits
    {
        Clubs, Diamonds, Hearts, Spades
    }
    public enum Face
    {
        One, Two, Three, Four, Five, Six, Seven, Eight,
        Nine, Ten, Jack, Queen, King, Ace,
    }
}

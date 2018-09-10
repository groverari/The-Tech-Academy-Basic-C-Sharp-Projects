using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValue = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };
        public static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.face == Face.Ace);
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x => _cardValue[x.face]);
            result[0] = value;
            if (result.Length == 1) return result;
            for(int i = 1; i< result.Length; i++)
            {
                value +=(i* 10);
                result[i] = value;
            }
            return result;
        }
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            bool BlackJack = possibleValues.Max() == 21;
            return BlackJack;

        }

        public static bool isBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            return value > 21;
        }
        public static bool ShouldStay(List<Card> Hand)
        {
            int[] values = GetAllPossibleHandValues(Hand);
            foreach(int value in values)
            {
                if (value > 16 && value < 22) return true;
            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] player = GetAllPossibleHandValues(PlayerHand);
            int[] dealer = GetAllPossibleHandValues(DealerHand);
            int playerScore = player.Where(x => x < 22).Max();
            int dealerScore = dealer.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }
    }
}


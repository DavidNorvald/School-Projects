using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects_Test
{
    public class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()      // private naming convention is to use the "_" underscore before the name
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
            [Face.Jacks] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1      // will add logic later to add 10 to the Ace to give it the ability to equal 11 as well
        };

        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            if (result.Length == 1) //return result;
            {
                return result;
            }
            for (int i = 1; 1 < result.Length; i++)         // i = 1 is for the Ace value, sinc ethe Aces value is equal to 1
            {
                value += value + (i * 10);      // i * 10 is adding 10 to the default value of Ace, so it can be either 1 or 10
                result[i] = value;      // can set a break point here for debugging, this logic is complex, play around with it by changing the values
            }
            return result;
        }


        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();       // Max = Lambda value
            if (value == 21) return true;
            else return false;
        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            int playerScore = playerResults.Where(x => x < 22).Max();       // highest possible score for player without busting
            int dealerScore = dealerResults.Where(x => x < 22).Max();       // highest possible score for dealer without busting

            if (playerScore > dealerScore) return true;
            if (playerScore < dealerScore) return false;
            else return null;
        }
    }
}

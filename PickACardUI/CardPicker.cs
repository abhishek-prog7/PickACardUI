using System;
using System.Collections.Generic;
using System.Text;

namespace PickACardUI
{
    class CardPicker
    {
        static Random random = new Random();
        /// <summary>
        /// This Methods Pick the random cards and returns the requested number of cards
        /// </summary>
        /// <param name="numberOfCards"></param>
        /// <returns></returns>
        public static string[] pickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for( int i=0; i<numberOfCards;i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;

        }

        private static string RandomSuit()
        {
            // get a random number from 1 to 4
            int value = random.Next(1, 5);
            if (value == 1) return "Spades";
            if (value == 2) return "Hearts";
            if (value == 3) return "Clubs";
            return "Diamond";

        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();

        }
    }
}

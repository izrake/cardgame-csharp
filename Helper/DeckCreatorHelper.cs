using System;
using System.Collections.Generic;
using System.Linq;
using Test.Models;

namespace Test.Helper
{
    public class DeckCreatorHelper: IDeckCreatorHelper
    {
        public  List<Card> GenerateCard()
        {
            List<Card> cards = new List<Card>();
            for (int i = 2; i <= 14; i++)
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    cards.Add(new Card()
                    {
                        Suit = suit,
                        Value = i,
                        Name = GetShortName(i, suit)
                    });
                }
            }
            return Shuffle(cards);
        }
        public List<Card> Shuffle(List<Card> cards)
        {
            //Shuffle the existing cards using Fisher-Yates Modern
            List<Card> transformedCards = cards.ToList();
            Random r = new Random();

            for (int n = transformedCards.Count - 1; n > 0; --n)
            {
                //Step 2: Randomly pick a card which has not been shuffled
                int k = r.Next(0, cards.Count);

                //Step 3: Swap the selected item with the last "unselected" card in the collection
                Card temp = transformedCards[n];
                transformedCards[n] = transformedCards[k];
                transformedCards[k] = temp;
            }

           

            return transformedCards;
        }

        private  string GetShortName(int value, Suit suit)
        {
            string valueDisplay = "";
            if (value >= 2 && value <= 10)
            {
                valueDisplay = value.ToString();
            }
            else if (value == 11)
            {
                valueDisplay = "J";
            }
            else if (value == 12)
            {
                valueDisplay = "Q";
            }
            else if (value == 13)
            {
                valueDisplay = "K";
            }
            else if (value == 14)
            {
                valueDisplay = "A";
            }

            return valueDisplay + Enum.GetName(typeof(Suit), suit)[0];
        }
    }
}

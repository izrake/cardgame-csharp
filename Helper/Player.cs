using System;
using System.Collections.Generic;
using System.Linq;
using Test.Models;

namespace Test.Helper
{
    public class Player: IPlayer
    {
        public string Name { get; set; }
        public List<Card> Deck { get; set; }

        public Player() { }

        public Player(string name)
        {
            Name = name;
        }

        public List<Card> Deal(List<Card> cards)
        {
            List<Card> player1cards = new List<Card>();
            List<Card> player2cards = new List<Card>();
            int index = 0;
            int counter = 2;
            while (cards.Any())
            {
                if(index == 52)
                {
                    break;
                }
                if (counter % 2 == 0) //Player who is not the dealer should get the first card
                {
                    player2cards.Add(cards[index]);
            
                }
                else
                {
                    player1cards.Add(cards[index]);
                }
                index++;
                counter++;
            }
           
            Deck = player1cards;
            return player2cards;
        }
    }
    
}

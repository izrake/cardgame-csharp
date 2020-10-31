using System;
using System.Collections.Generic;
using System.Linq;
using Test.Helper;
using Test.Models;

namespace Test.Mangers
{
    public class CardGameManager
    {
        private Player Player1;
        private Player Player2;
        public int TurnCount;
        
        public CardGameManager(string playerOneName, string playerTwoName)
        {
            IDeckCreatorHelper helper = new DeckCreatorHelper();
            Player1 = new Player(playerOneName);
            Player2 = new Player(playerTwoName);

            var cards = helper.GenerateCard(); //Returns a shuffled set of cards

            var deck = Player1.Deal(cards); //Returns Player2's deck.  Player1 keeps his.
            Player2.Deck = deck;
        }

        public void ReShuffle()
        {
            IDeckCreatorHelper helper = new DeckCreatorHelper();
            Player1.Deck =  helper.Shuffle(Player1.Deck);
        }

        /// <summary>
        /// Play the card randomly from the user deck and computer
        /// </summary>
        public void PlayTurn()
        {
            List<Card> pool = new List<Card>();

            var randomPlayerOne = new Random();

            if(Player1.Deck.Count == 0)
            {
                throw new Exception($"{Player1.Name} you have exhausted all your cards");
            }
            if (Player2.Deck.Count == 0)
            {
                throw new Exception($"{Player2.Name} you have exhausted all your cards");
            }
            var randomIndexPlayerOne = randomPlayerOne.Next(0, Player1.Deck.Count-1);

            var randomIndexPlayerTwo = randomPlayerOne.Next(0, Player2.Deck.Count-1);
            var player1card = Player1.Deck[randomIndexPlayerOne];

            var player2card = Player2.Deck[randomIndexPlayerTwo];

            pool.Add(player1card);
            pool.Add(player2card);

            Console.WriteLine(Player1.Name + " plays " + player1card.Name + ", " + Player2.Name + " plays " + player2card.Name);


            // Once players play their turn deck holded should be reduced
            Player1.Deck.RemoveAt(randomIndexPlayerOne);
            Player2.Deck.RemoveAt(randomIndexPlayerTwo);


            Console.WriteLine($"{Player1.Name} you have only {Player1.Deck.Count} remaining");

        }
    }
}

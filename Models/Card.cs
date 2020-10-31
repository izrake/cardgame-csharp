using System;
namespace Test.Models
{
    public class Card
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public Suit Suit { get; set; }

    }

    public enum Suit
    {
        Heart,
        Spades,
        Diamond,
        Clubs
    }
}

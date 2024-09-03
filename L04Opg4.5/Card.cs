namespace L04Opg4._5
{
    public enum Suit
    {
        Clubs = 0,
        Spades = 1,
        Diamonds = 2,
        Hearts = 3
    }
    
    public enum Number
    {
        Ace = 0, 
        Two = 1,
        Three = 2,
        Four = 3, 
        Five = 4,
        Six = 5,
        Seven = 6,
        Eight = 7,
        Nine = 8,
        Ten = 9,
        Jack = 10,
        Queen = 11,
        King = 12
    }

    internal class Card
    {
        public Card(Suit suit, Number number)
        {
            Suit = suit;
            Number = number;
        }
        public Suit Suit { get; set; }
        public Number Number { get; set; }

        public override string ToString()
        {
            return Number + " of " + Suit + "'s";
        }
    }
    
}


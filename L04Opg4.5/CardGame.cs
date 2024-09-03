

namespace L04Opg4._5
{
    internal class CardGame
    {
        private List<Card> cards = new List<Card>();

        public void AddCard(Suit suit, Number number)
        {
            cards.Add(new Card(suit, number));
        }
        
    }
}
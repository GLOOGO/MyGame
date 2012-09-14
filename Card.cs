namespace MyGame
{
    public class Card
    {
        public CardType CardType { get; set; }

        public Card(CardType cardType)
        {
            CardType = cardType;
        }
    }
}
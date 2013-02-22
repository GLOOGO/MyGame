namespace Domain
{
    public class Card
    {
        public CardType CardType { get; set; }
        public bool GoesOnBattlefield { get; set; }

        public Card(CardType cardType, bool goesOnBattlefield)
        {
            CardType = cardType;
            GoesOnBattlefield = goesOnBattlefield;
        }
    }
}
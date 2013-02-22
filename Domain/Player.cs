using System.Collections.Generic;

namespace Domain
{
    public class Player
    {
        private List<Card> _deck = MasterDecks.GetPlayerDeck();
        private List<Card> _hand = new List<Card>();
        private List<Card> _battlefield = new List<Card>();
        private List<Card> _discardPile = new List<Card>();
        private int _turnNumber = 0;
        private int _gems = 5;

        public string Name { get; set; }

        public int Gems { get; set; }

        public List<Card> Deck
        {
            get { return _deck; }
            set { _deck = value; }
        }

        public List<Card> Hand
        {
            get { return _hand; }
            set { _hand = value; }
        }

        public List<Card> Battlefield
        {
            get { return _battlefield; }
            set { _battlefield = value; }
        }

        public List<Card> DiscardPile
        {
            get { return _discardPile; }
            set { _discardPile = value; }
        }

        public void TakeTurn(IPlayerInteraction playerInteraction)
        {
            int actionsLeft = 1;
            int buysLeft = 1;

            Draw();
            playerInteraction.DisplayHand(Hand);

            var endTurn = false;
            while (actionsLeft + buysLeft > 0 && !endTurn)
            {
                int actionChoice = playerInteraction.PromptPlayerForTurnChoice();

                switch (actionChoice)
                {
                    case 1: //Play a Card
                        ChoseAndPlayCard(playerInteraction);
                        actionsLeft--;
                        break;

                    case 2: //Buy a Card
                        BuyCard(playerInteraction);
                        buysLeft--;
                        break;
                    case 3:
                        endTurn = true;
                        break;

                }

            }

            playerInteraction.DisplayHand(Hand);
            playerInteraction.DisplayBattleField(Battlefield);
            Gems++;
        }

        private void Draw()
        {
            _turnNumber++;
            int numberOfCardsToDraw = _turnNumber == 1 ? 5 : 1;
            Draw(numberOfCardsToDraw);
        }

        private void Draw(int numberOfCardsToDraw)
        {
            Hand.AddRange(Deck.GetRange(0, numberOfCardsToDraw));
            Deck.RemoveRange(0, numberOfCardsToDraw);
            if (Deck.Count == 0)
            {
                DiscardPile.Shuffle();
                Deck.AddRange(DiscardPile.GetRange(0, DiscardPile.Count));
                DiscardPile.Clear();
            }
        }

        private void BuyCard(IPlayerInteraction playerInteraction)
        {
            int buyChoice = playerInteraction.PromptPlayerForBuyChoice();

            switch (buyChoice)
            {
                case 1:
                    Hand.Add(new Card(CardType.Item, true));
                    Gems = Gems - 5;
                    break;
                case 2:
                    Hand.Add(new Card(CardType.Spell, true));
                    Gems = Gems - 5;
                    break;
                case 3:
                    Hand.Add(new Card(CardType.Action, true));
                    Gems = Gems - 5;
                    break;
            }
        }

        private void ChoseAndPlayCard(IPlayerInteraction playerInteraction)
        {
            Card chosenCard = playerInteraction.PromptPlayerForCardToPlay(Hand);

            PlaceCard(chosenCard);
        }

        private void PlaceCard(Card card)
        {
            if (card.GoesOnBattlefield)
            {
                Battlefield.Add(card);
            }
            else
            {
                DiscardPile.Add(card);
            }

            Hand.Remove(card);

        }
    }
}
using System;
using System.Collections.Generic;

namespace MyGame
{
    public class Player
    {
        private List<Card> _deck = GenerateRandomDeck();
        private List<Card> _hand = new List<Card>();
        private List<Card> _battlefield = new List<Card>();
        private List<Card> _discardPile = new List<Card>();
        private int _turnNumber = 0;

        public string Name { get; set; }
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

        private static List<Card> GenerateRandomDeck()
        {
            List<Card> deck = new List<Card>();

            deck.Add(new Card(CardType.Hero, true));
            deck.AddRange(GetCardsOfType(20, CardType.Basic, true));
            deck.AddRange(GetCardsOfType(5, CardType.Magic, true));
            deck.AddRange(GetCardsOfType(20, CardType.Action, false));
            deck.AddRange(GetCardsOfType(16, CardType.Item, true));
            deck.AddRange(GetCardsOfType(10, CardType.Spell, true));
            deck.AddRange(GetCardsOfType(3, CardType.ElementalAura, true));
            deck.AddRange(GetCardsOfType(3, CardType.PowerAura, true));
            deck.AddRange(GetCardsOfType(3, CardType.ShadowAura, true));
            deck.AddRange(GetCardsOfType(3, CardType.LightAura, true));
            deck.AddRange(GetCardsOfType(3, CardType.TimeAura, true));
            deck.AddRange(GetCardsOfType(3, CardType.SkillAura, true));

            deck.Shuffle();

            return deck;
        }

        private static List<Card> GetCardsOfType(int numberOfCards, CardType cardType, bool goesOnBattlefield)
        {
            List<Card> cards = new List<Card>();
            for (int i = 0; i < numberOfCards; i++)
            {
                cards.Add(new Card(cardType, goesOnBattlefield));
            }
            return cards;
        }

        public void TakeTurn()
        {
            _turnNumber++;
            int numberOfCardsToDraw = _turnNumber == 1 ? 5 : 1;
            Draw(numberOfCardsToDraw);
        }

        private void Draw(int numberOfCardsToDraw)
        {
            Hand.AddRange(Deck.GetRange(0, numberOfCardsToDraw));
            Deck.RemoveRange(0, numberOfCardsToDraw);
        }


    }
}
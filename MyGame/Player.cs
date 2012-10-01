using System;
using System.Collections.Generic;

namespace MyGame
{
    public class Player
    {
        private List<Card> _deck = _cardFactory.GenerateRandomDeck();
        private List<Card> _hand = new List<Card>();
        private List<Card> _battlefield = new List<Card>();
        private List<Card> _discardPile = new List<Card>();
        private static CardFactory _cardFactory = new CardFactory();
        private int _turnNumber = 0;
        private int _gems = 5;

        public string Name { get; set; }

        public int Gems { get; set; }
        public CardFactory CardFactory
        {
            get { return _cardFactory; }
            set { _cardFactory = value; }
        }
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

        

       

        private void Reshuffle()
        {
            
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
            if (Deck.Count == 0)
            {
                DiscardPile.Shuffle();
                Deck.AddRange(DiscardPile.GetRange(0, DiscardPile.Count));
                DiscardPile.Clear();

            }
        }


    }
}
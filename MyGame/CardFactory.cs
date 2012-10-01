using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyGame
{
    public class CardFactory
    {

        public List<Card> GetCardsOfType(int numberOfCards, CardType cardType, bool goesOnBattlefield)
        {
            List<Card> cards = new List<Card>();
            for (int i = 0; i < numberOfCards; i++)
            {
                cards.Add(new Card(cardType, goesOnBattlefield));
            }
            return cards;
        }

        public List<Card> GenerateRandomDeck()
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

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyGame.MagicMonsters;

namespace MyGame
{
    public static class MasterDecks
    {
        private static List<Card> _startDeck = GenerateStartDeck();

        private static List<Card> GenerateStartDeck()
        {
            List<Card> startDeck = new List<Card>();
            startDeck.AddRange(GetCardsOfType(54, CardType.Hero, true));
            startDeck.AddRange(GetCardsOfType(15, CardType.ElementalAura, true));
            startDeck.AddRange(GetCardsOfType(15, CardType.PowerAura, true));
            startDeck.AddRange(GetCardsOfType(15, CardType.ShadowAura, true));
            startDeck.AddRange(GetCardsOfType(15, CardType.LightAura, true));
            startDeck.AddRange(GetCardsOfType(15, CardType.TimeAura, true));
            startDeck.AddRange(GetCardsOfType(15, CardType.SkillAura, true));
            startDeck.AddRange(GetCardsOfType(171, CardType.Action, false));
            startDeck.AddRange(GetCardsOfType(108, CardType.Item, true));
            startDeck.AddRange(GetCardsOfType(100, CardType.Spell, true));
            startDeck.AddRange(GetCardsOfType(60, CardType.Quest, false));
            startDeck.AddRange(GetCardsOfType(8, CardType.Boss, false));
            startDeck.AddRange(GetCardsOfType(15, CardType.Mercenary, false));
            startDeck.AddRange(GetCardsOfType(15, CardType.Mercenary, false));
            startDeck.Add(new Slime());
            startDeck.Add(new Slime());
            startDeck.Add(new Slime());
            startDeck.Add(new Slime());

            startDeck.Shuffle();

            return startDeck;
        }

        public static List<Card> GetPlayerDeck()
        {
            List<Card> deck = new List<Card>();

            deck.AddRange(_startDeck.Where(card => card.CardType == CardType.Hero).Take(1));
            deck.AddRange(_startDeck.Where(card => card.CardType == CardType.Action).Take(20));
            deck.AddRange(_startDeck.Where(card => card.CardType == CardType.Item).Take(16));
            deck.AddRange(_startDeck.Where(card => card.CardType == CardType.Spell).Take(10));
            deck.AddRange(_startDeck.Where(card => card.CardType == CardType.MagicMonster).Take(5));
            deck.AddRange(_startDeck.Where(card => card.CardType == CardType.BasicMonster).Take(20));
            deck.AddRange(_startDeck.Where(card => card.CardType == CardType.ElementalAura).Take(3));
            deck.AddRange(_startDeck.Where(card => card.CardType == CardType.PowerAura).Take(3));
            deck.AddRange(_startDeck.Where(card => card.CardType == CardType.ShadowAura).Take(3));
            deck.AddRange(_startDeck.Where(card => card.CardType == CardType.LightAura).Take(3));
            deck.AddRange(_startDeck.Where(card => card.CardType == CardType.TimeAura).Take(3));
            deck.AddRange(_startDeck.Where(card => card.CardType == CardType.SkillAura).Take(3));

            _startDeck.RemoveAll(card => deck.Contains(card));

            deck.Shuffle();

            return deck;
        }

        public static List<Card> GetCardsOfType(int numberOfCards, CardType cardType, bool goesOnBattlefield)
        {
            List<Card> cards = new List<Card>();
            for (int i = 0; i < numberOfCards; i++)
            {
                cards.Add(new Card(cardType, goesOnBattlefield));
            }
            return cards;
        }
    }
}

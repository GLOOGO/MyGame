using System;
using System.Collections.Generic;

namespace MyGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Player> players = new List<Player>();
            string gameLength;

            Console.WriteLine("How many players? ");
            int numberOfPlayers = GetNumber();

            for(int i = 1; i <= numberOfPlayers; i++)
            {
                Console.WriteLine("Enter the name of Player {0}: ", i);
                
                Player player = new Player();
                player.Name = Console.ReadLine();
                player.Deck = GenerateRandomDeck();
                player.Hand = new List<Card>(); 
                players.Add(player);
            }

            Console.WriteLine("Enter the game length (short, long): ");
            gameLength = Console.ReadLine();


            Shuffle(players);

            Console.WriteLine("The players will go in this order: ");

            foreach (var player in players)
            {
                Console.WriteLine(player.Name);
            }

            Console.WriteLine("\n");

            int currentPlayerIndex = 0;
            bool isFirstTurn = true;
            while (true)
            {
                Player currentPlayer = players[currentPlayerIndex];
                if (isFirstTurn)
                {
                    DrawCards(currentPlayer, 5);
                }
                else
                {
                    DrawCards(currentPlayer, 1);
                }


                int writeNumber = 0;
                foreach (Card card in currentPlayer.Hand)
                {
                    
                    Console.Write(writeNumber + 1);
                    Console.Write(". ");
                    Console.WriteLine(card.CardType.ToString());
                    writeNumber++;

                }

                if (currentPlayerIndex == players.Count - 1)
                {
                    isFirstTurn = false;
                    currentPlayerIndex = 0;
                }
                else
                {
                    currentPlayerIndex++;
                }

                Console.WriteLine("Choose a card to play.");
                Console.ReadLine();
                ChooseCard();
                Console.WriteLine("Does the card go on the Battlefield?");
                Console.ReadLine();

                PlaceCardBattlefield(currentPlayer);
                
                
            }
            Console.ReadLine();
        }

        private static void PlaceCardBattlefield(Player player)
        {
            int chosenCard = 1;
            player.Battlefield.AddRange((player.Hand.GetRange(1, ChooseCard(chosenCard))));
            player.Hand.RemoveRange(1, chosenCard);

        }

        private static int ChooseCard(int cardChoice)
        {
            int temp = GetNumber();
            cardChoice = temp - 1;
            return cardChoice;
        }

        private static void DrawCards(Player player, int numberOfCardsToDraw)
        {
            player.Hand.AddRange(player.Deck.GetRange(0, numberOfCardsToDraw));
            player.Deck.RemoveRange(0, numberOfCardsToDraw);
        }

        private static void DisplayPlayerDecks(List<Player> players)
        {
            foreach (Player player in players)
            {
                Console.WriteLine("{0}'s cards are:", player.Name);
                foreach (var card in player.Deck)
                {
                    Console.WriteLine(card.CardType.ToString());
                }
                Console.WriteLine("********************************");
                Console.WriteLine("");
            }
        }

        private static List<Card> GenerateRandomDeck()
        {
            List<Card> deck = new List<Card>();

            deck.Add(new Card(CardType.Hero));
            deck.AddRange(GetCardsOfType(20, CardType.Basic));
            deck.AddRange(GetCardsOfType(5, CardType.Magic));
            deck.AddRange(GetCardsOfType(20, CardType.Action));
            deck.AddRange(GetCardsOfType(16, CardType.Item));
            deck.AddRange(GetCardsOfType(10, CardType.Spell));
            deck.AddRange(GetCardsOfType(3, CardType.ElementalAura));
            deck.AddRange(GetCardsOfType(3, CardType.PowerAura));
            deck.AddRange(GetCardsOfType(3, CardType.ShadowAura));
            deck.AddRange(GetCardsOfType(3, CardType.LightAura));
            deck.AddRange(GetCardsOfType(3, CardType.TimeAura));
            deck.AddRange(GetCardsOfType(3, CardType.SkillAura));

            Shuffle(deck);

            return deck;
        }

        private static void Shuffle<T>(List<T> list)
        {
            Random random = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T item = list[k];
                list[k] = list[n];
                list[n] = item;
            }

        }

        private static List<Card> GetCardsOfType(int numberOfCards, CardType cardType)
        {
            List<Card> cards = new List<Card>();
            for (int i = 0; i < numberOfCards; i++)
            {
                cards.Add(new Card(cardType));
            }
            return cards;
        }

        private static int GetNumber()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
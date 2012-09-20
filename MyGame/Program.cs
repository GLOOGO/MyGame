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
                players.Add(player);
            }

            Console.WriteLine("Enter the game length (short, long): ");
            gameLength = Console.ReadLine();


            players.Shuffle();

            Console.WriteLine("The players will go in this order: ");

            foreach (var player in players)
            {
                Console.WriteLine(player.Name);
            }

            Console.WriteLine("\n");

            int currentPlayerIndex = 0;
            while (true)
            {
                Player currentPlayer = players[currentPlayerIndex];
   currentPlayer.TakeTurn();

                Console.WriteLine("Here is {0}'s hand:", currentPlayer.Name);
                DisplayCards(currentPlayer.Hand);

             


                Console.WriteLine("Choose a card to play.");
                Card chosenCard = ChooseCard(currentPlayer);
                Console.WriteLine("You chose this card: " + chosenCard.CardType.ToString());

                PlaceCard(currentPlayer, chosenCard);
                
                Console.WriteLine("Here is your hand:");
                DisplayCards(currentPlayer.Hand);
                Console.WriteLine("\n");
                Console.WriteLine("Here is your Battlefield:");
                DisplayCards(currentPlayer.Battlefield);
                Console.WriteLine("\n");
                Console.WriteLine("Here is your discard pile:");
                DisplayCards(currentPlayer.DiscardPile);
                Console.WriteLine("\n");

                if (currentPlayerIndex == players.Count - 1)
                {
                    currentPlayerIndex = 0;
                }
                else
                {
                    currentPlayerIndex++;
                }

            }
            Console.ReadLine();
        }

        private static void DisplayCards(List<Card> cards)
        {
            int writeNumber = 0;
            foreach (Card card in cards)
            {
                Console.Write(writeNumber + 1);
                Console.Write(". ");
                Console.WriteLine(card.CardType.ToString());
                writeNumber++;
            }
        } 

        private static void PlaceCard(Player player, Card card)
        {
            if (card.GoesOnBattlefield)
            {
                player.Battlefield.Add(card);
            }
            else
            {
                player.DiscardPile.Add(card);
            }
            
            player.Hand.Remove(card);

        }

        private static Card ChooseCard(Player currentPlayer)
        {
            return currentPlayer.Hand[GetNumber() - 1];
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

       

        private static int GetNumber()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
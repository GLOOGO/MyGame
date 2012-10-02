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
            Console.WriteLine();


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
                int actionsLeft = 1;
                int buysLeft = 1;


                Console.WriteLine("Here is {0}'s hand:", currentPlayer.Name);
                DisplayCards(currentPlayer.Hand);
                var endTurn = false;
                while ( actionsLeft + buysLeft > 0 && !endTurn)
                {
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. Play a card.");
                    Console.WriteLine("2. Buy a card.");
                    Console.WriteLine("3. End Turn");

                    int actionChoice = GetNumber();

                    switch (actionChoice)
                    {
                        case 1:
                            Console.WriteLine("Choose a card to play.");
                            Card chosenCard = ChooseCard(currentPlayer);
                            Console.WriteLine("You chose this card: " + chosenCard.CardType.ToString());
                            PlaceCard(currentPlayer, chosenCard);
                            actionsLeft--;
                            break;

                            
                        case 2:
                            Console.WriteLine("What would you like to buy?");
                            Console.WriteLine("1. Item");
                            Console.WriteLine("2. Spell");
                            Console.WriteLine("3. Action");
                            int buyChoice = GetNumber();
                            switch (buyChoice)
                            {
                                case 1:
                                    currentPlayer.Hand.Add(new Card(CardType.Item, true));
                                    currentPlayer.Gems = currentPlayer.Gems - 5;
                                    break;
                                case 2:
                                    currentPlayer.Hand.Add(new Card(CardType.Spell, true));
                                    currentPlayer.Gems = currentPlayer.Gems - 5;
                                    break;
                                case 3:
                                    currentPlayer.Hand.Add(new Card(CardType.Action, true));
                                    currentPlayer.Gems = currentPlayer.Gems - 5;
                                    break;

                            }
                            buysLeft--;
                            break;
                        case 3:
                            endTurn = true;
                            break;

                    }
                    
                }

                
                Console.WriteLine("Here is your hand:");
                DisplayCards(currentPlayer.Hand);
                Console.WriteLine("\n");
                Console.WriteLine("Here is your Battlefield:");
                DisplayCards(currentPlayer.Battlefield);
                Console.WriteLine("\n");
                Console.WriteLine("Here is your discard pile:");
                DisplayCards(currentPlayer.DiscardPile);
                Console.WriteLine("\n");
                currentPlayer.Gems++;



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
using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace MyGame
{
    internal class Program
    {
        private static IPlayerInteraction _playerInteraction;
//
        private static void Main(string[] args)
        {
//            _playerInteraction = new ConsolePlayerInteraction();
//
//            List<Player> players = GetPlayers();
//
//            int currentPlayerIndex = 0;
//            while (true)
//            {
//                Player currentPlayer = players[currentPlayerIndex];
//
//                currentPlayer.TakeTurn(_playerInteraction);
//
//                currentPlayerIndex = GetNextPlayerIndex(currentPlayerIndex, players);
//            }
        }
//
//        private static int GetNextPlayerIndex(int currentPlayerIndex, List<Player> players)
//        {
//            if (currentPlayerIndex == players.Count - 1)
//            {
//                currentPlayerIndex = 0;
//            }
//            else
//            {
//                currentPlayerIndex++;
//            }
//            return currentPlayerIndex;
//        }
//
//        private static List<Player> GetPlayers()
//        {
//            List<string> playerNames = _playerInteraction.GetPlayerNames();
//            List<Player> players = playerNames.Select(x => new Player {Name = x}).ToList();
//
//            players.Shuffle();
//
//            _playerInteraction.DisplayMessage("The players will go in this order: ");
//
//            foreach (var player in players)
//            {
//                _playerInteraction.DisplayMessage(player.Name);
//            }
//
//            _playerInteraction.DisplayMessage("\n");
//            return players;
//        }
//
//        private static void DisplayPlayerDecks(List<Player> players)
//        {
//            foreach (Player player in players)
//            {
//                Console.WriteLine("{0}'s cards are:", player.Name);
//                foreach (var card in player.Deck)
//                {
//                    Console.WriteLine(card.CardType.ToString());
//                }
//                Console.WriteLine("********************************");
//                Console.WriteLine("");
//            }
//        }

       

    }
}
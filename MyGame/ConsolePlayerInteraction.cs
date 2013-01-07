using System;
using System.Collections.Generic;

namespace MyGame
{
    public class ConsolePlayerInteraction : IPlayerInteraction
    {
         public int PromptPlayerForTurnChoice()
         {
             Console.WriteLine("What would you like to do?");
             Console.WriteLine("1. Play a card.");
             Console.WriteLine("2. Buy a card.");
             Console.WriteLine("3. End Turn");

             int actionChoice = GetNumber();

             return actionChoice;

         }

        public int PromptPlayerForCardToPlay()
        {
            Console.WriteLine("Choose a card to play.");
            int cardNumber = GetNumber();
            return cardNumber;
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public int PromptPlayerForBuyChoice()
        {
            Console.WriteLine("What would you like to buy?");
            Console.WriteLine("1. Item");
            Console.WriteLine("2. Spell");
            Console.WriteLine("3. Action");

            return GetNumber();

        }

        public List<string> GetPlayerNames()
        {
            List<string> playerNames = new List<string>();
            Console.WriteLine("How many players? ");
            int numberOfPlayers = GetNumber();

            for (int i = 1; i <= numberOfPlayers; i++)
            {
                Console.WriteLine("Enter the name of Player {0}: ", i);
                playerNames.Add(Console.ReadLine());
            }
            return playerNames;
        }


        private static int GetNumber()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
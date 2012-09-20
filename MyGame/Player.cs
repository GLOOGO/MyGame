using System;
using System.Collections.Generic;

namespace MyGame
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Deck { get; set; }
        public List<Card> Hand { get; set; }
        public List<Card> Battlefield { get; set; }
        public List<Card> DiscardPile { get; set; }
    }
}
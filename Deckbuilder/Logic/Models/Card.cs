using System;
using System.Collections.Generic;
using System.Text;

namespace Deckbuilder.Logic.Models
{
    /*public enum CardType
    {
        Creature,
        Artifact,
        Enchantment,
        PlanesWalker,
        Sorcery,
        Instant
    }*/

    public class Card
    {
        public string Name { get; }
        public Id<Card> Id { get; set; }

        //public CardType CardType { get; set; }
        //public int Power { get; set; }
        //public int Toughness { get; set; }

        public Card(Id<Card> id, string name)
        {
            Name = name;
            Id = id;
        }
    }
}

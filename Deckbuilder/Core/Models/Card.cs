using System;
using System.Collections.Generic;
using System.Text;
using Deckbuilder.Common;

namespace Deckbuilder.Logic.Models
{
    public class Card
    {
        public string Name { get; }
        public CardId Id { get; }

        public Card(CardId id, string name)
        {
            Name = name;
            Id = id;
        }
    }
}

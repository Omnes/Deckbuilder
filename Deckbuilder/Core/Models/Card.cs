using System;
using System.Collections.Generic;
using System.Text;
using Deckbuilder.Common;

namespace Deckbuilder.Logic.Models
{
    public class Card : IEntity<Card>
    {
        public string Name { get; }
        public Id<Card> Id { get; }

        public Card(Id<Card> id, string name)
        {
            Name = name;
            Id = id;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Deckbuilder.Models
{
    public class WorkspaceCard
    {
        public Card Card { get; }
        public List<Tag> Tags { get; set; }

        public WorkspaceCard(Card card)
        {
            Card = card;
            Tags = new List<Tag>();
        }
    }
}

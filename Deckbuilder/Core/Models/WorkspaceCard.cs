using System;
using System.Collections.Generic;
using System.Text;
using Deckbuilder.Common;

namespace Deckbuilder.Logic.Models
{
    public class WorkspaceCard : IEntity<WorkspaceCard>
    {
        public Id<Card> CardId { get; }
        public List<Id<Tag>> TagIds { get; set; }
        public Id<WorkspaceCard> Id { get; set; }

        public WorkspaceCard(Id<WorkspaceCard> id, Card card)
        {
            CardId = card.Id;
            Id = id;
            TagIds = new List<Id<Tag>>();
        }
    }
}

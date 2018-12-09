using System;
using System.Collections.Generic;
using System.Text;
using Deckbuilder.Common;

namespace Deckbuilder.Logic.Models
{
    public class DeckCard : IEntity<DeckCard>
    {
        public Id<DeckCard> Id { get; }
        public Id<WorkspaceCard> WorkspaceCardId { get; }
        public int Quantity { get; }

        public DeckCard(Id<DeckCard> id, Id<WorkspaceCard> workspaceCardId, int quantity)
        {
            Id = id;
            WorkspaceCardId = workspaceCardId;
            Quantity = quantity;
        }
    }
}

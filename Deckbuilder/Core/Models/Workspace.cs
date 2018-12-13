using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Deckbuilder.Common;

namespace Deckbuilder.Logic.Models
{
    public class Workspace : IEntity<Workspace>
    {
        public List<DeckCard> DeckCards { get; } //Deck should be its own object, it doesnt matter for this layer but 
        public List<WorkspaceCard> WorkspaceCards { get; }
        public List<Tag> Tags { get; }
        public Id<Workspace> Id { get; }

        public Workspace()
        {
            DeckCards = new List<DeckCard>();
            WorkspaceCards = new List<WorkspaceCard>();
            Tags = new List<Tag>();
        }

        public void AddCard(Card card)
        {
            var nextId = Id<WorkspaceCard>.GetNextId(WorkspaceCards);
            var workspaceCard = new WorkspaceCard(nextId, card);
            WorkspaceCards.Add(workspaceCard);
        }

        public void CreateTag(string tagName)
        {
            var nextId = Id<Tag>.GetNextId(Tags);
            var tag = new Tag(nextId, tagName);
            Tags.Add(tag);
        }

        public void AddTag(WorkspaceCard workspaceCard, Tag tag)
        {
            workspaceCard.TagIds.Add(tag.Id);
        }

        public void AddToDeck(WorkspaceCard workspaceCard)
        {
            throw new NotImplementedException();
        }


    }
}

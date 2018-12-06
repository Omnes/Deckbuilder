using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Deckbuilder.Logic.Models
{
    public class Workspace
    {
        public List<DeckCard> DeckCards { get; set; }
        public List<WorkspaceCard> WorkspaceCards { get; set; }
        public List<Tag> Tags { get; set; }  //hur ska jag göra med dessa? ska workspace och workspace card ha egna varianter av den? ska varje tag ha en list med kort?
        public List<Card> Cards { get; set; } //hör dessa hemma här? Nope de hör helt till CardSource
        public Id<Workspace> Id { get; set; }

        public Workspace()
        {
            DeckCards = new List<DeckCard>();
            WorkspaceCards = new List<WorkspaceCard>();
            Tags = new List<Tag>();
        }

        public void AddCard(Card card)
        {
            var nextId = GetNextWorkspaceCardId();
            var workspaceCard = new WorkspaceCard(nextId, card);
            WorkspaceCards.Add(workspaceCard);
        }

        public void CreateTag(string tagName)
        {
            var nextId = GetNextTagId();
            var tag = new Tag(nextId, tagName);
            Tags.Add(tag);
        }

        public void AddTag(WorkspaceCard workspaceCard, Tag tag)
        {
            throw new NotImplementedException();
        }

        public void AddToDeck(WorkspaceCard workspaceCard)
        {
            throw new NotImplementedException();
        }

        //Generalisera
        private Id<WorkspaceCard> GetNextWorkspaceCardId()
        {
            if (WorkspaceCards.Any())
                return new Id<WorkspaceCard>(WorkspaceCards.Select(wc => wc.Id.Value).Max() + 1);
            return new Id<WorkspaceCard>(0);
        }

        private Id<Tag> GetNextTagId()
        {
            if (Tags.Any())
                return new Id<Tag>(Tags.Select(tag => tag.Id.Value).Max() + 1);
            return new Id<Tag>(0);
        }

        private Id<DeckCard> GetDeckCardId()
        {
            if (DeckCards.Any())
                return new Id<DeckCard>(DeckCards.Select(dc => dc.Id.Value).Max() + 1);
            return new Id<DeckCard>(0);
        }
    }
}

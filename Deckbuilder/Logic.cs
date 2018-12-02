using System;
using System.Collections.Generic;
using System.Text;
using Deckbuilder.Models;
using Deckbuilder.Interfaces;

namespace Deckbuilder
{
    public class Logic
    {
        public ICardSource CardSource { get; set; }
        public IStorage Storage { get; set; }

        public void AddCard(string cardName)
        {
            var card = CardSource.GetCard(cardName);
            var workspaceCard = new WorkspaceCard(card);
            Storage.AddWorkspaceCard(workspaceCard);
        }

        public void AddTag(string cardName, string tagName)
        {
            var workspace = Storage.GetWorkSpace();
            var wcCard = workspace.WorkspaceCards.Find(wc => wc.Card.Name == cardName);
            Storage.AddTag(wcCard, new Tag { Name = tagName });
        }

        public void RemoveCard(string cardName)
        {
            throw new NotImplementedException();
        }

        public Workspace GetWorkspace()
        {
            return Storage.GetWorkSpace();
        }

        public Deck GetDeck()
        {
            throw new NotImplementedException();
        }
    }
}

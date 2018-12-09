using System;
using System.Collections.Generic;
using System.Text;
using Deckbuilder.Logic.Interfaces;
using Deckbuilder.Logic.Models;

namespace Deckbuilder.UI
{
    /// <summary>
    /// Should contain all logic the ui needs to interact with the inner layers
    /// </summary>
    public class UiAdapter
    {
        private readonly ICardSource _cardSource;
        private readonly IStorage _storage;

        public UiAdapter(ICardSource cardSource, IStorage storage)
        {
            _cardSource = cardSource;
            _storage = storage;
        }

        public Logic.Models.WorkspaceCard GetWorkspaceCardByCardName(Logic.Models.Workspace workspace, string cardName)
        {
            var card = _cardSource.GetCard(cardName);
            return workspace.WorkspaceCards.Find(wc => wc.CardId == card.Id);
        }

        public void AddCard(string cardName)
        {
            var workspace = _storage.GetWorkSpace();
            var card = _cardSource.GetCard(cardName);
            workspace.AddCard(card);
        }

        public void CreateTag(string tagName)
        {
            var workspace = _storage.GetWorkSpace();
            workspace.CreateTag(tagName);
        }

        public void AddCardToDeck(string cardName)
        {
            var workspace = _storage.GetWorkSpace();
            var workspaceCard = GetWorkspaceCardByCardName(workspace, cardName);
            workspace.AddToDeck(workspaceCard);
        }

        public void AddTag(string cardName, string tagName)
        {
            var workspace = _storage.GetWorkSpace();
            // dessa properties borde kanske inte exponeras alls utåt
            var tag = workspace.Tags.Find(t => t.Name == tagName);

            var workspaceCard = GetWorkspaceCardByCardName(workspace, cardName);
            workspace.AddTag(workspaceCard, tag);
        }

        public List<WorkspaceCard> GetWorkspaceCards()
        {
            var workspace = _storage.GetWorkSpace();
            return workspace.WorkspaceCards;
        }

        public List<DeckCard> GetDeckCards()
        {
            var workspace = _storage.GetWorkSpace();
            return workspace.DeckCards;
        }
    }
}

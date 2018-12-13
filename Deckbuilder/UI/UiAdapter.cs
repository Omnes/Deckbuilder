using System;
using System.Collections.Generic;
using System.Text;
using Deckbuilder.Logic.Interfaces;
using Deckbuilder.Logic.Models;
using System.Linq;

namespace Deckbuilder.UI
{
    public class UiWorkspaceCard
    {
        public string CardName { get; set; }
        public string TagNames { get; set; }
    }

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

        private UiWorkspaceCard Convert(WorkspaceCard workspaceCard)
        {
            var workspace = _storage.GetWorkSpace();
            var tags = workspaceCard.TagIds.Select(tId => workspace.Tags.Find(t => t.Id == tId).Name);
            return new UiWorkspaceCard
            {
                CardName = _cardSource.GetCardById(workspaceCard.CardId).Name,
                TagNames = string.Join(", ", tags.ToArray())
            };
        }

        public List<UiWorkspaceCard> GetWorkspaceCards()
        {
            var workspace = _storage.GetWorkSpace();
            return workspace.WorkspaceCards.Select(Convert).ToList();
        }

        public List<DeckCard> GetDeckCards()
        {
            var workspace = _storage.GetWorkSpace();
            return workspace.DeckCards;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Deckbuilder.Common;
using Deckbuilder.Logic.Models;
using System.Linq;

namespace Deckbuilder.CardSource.Magic
{
    public class InMemoryMagicCardStorage : ICardStorage
    {
        private List<Card> _cards; 

        public InMemoryMagicCardStorage()
        {
            _cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            _cards.Add(card);
        }

        public Card GetCard(string cardName)
        {
            return _cards.Find(c => c.Name == cardName);
        }

        public Card GetCardById(CardId cardId)
        {
            return _cards.Find(c => c.Id == cardId);
        }

        public bool HasCard(string cardName)
        {
            return _cards.Any(c => c.Name == cardName);
        }
    }
}

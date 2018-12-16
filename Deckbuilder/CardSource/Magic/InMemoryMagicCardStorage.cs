using System;
using System.Collections.Generic;
using System.Text;
using Deckbuilder.Common;
using Deckbuilder.Logic.Models;

namespace Deckbuilder.CardSource.Magic
{
    public class InMemoryMagicCardStorage : ICardStorage
    {
        public void AddCard(Card card)
        {
            throw new NotImplementedException();
        }

        public Card GetCard(string cardName)
        {
            throw new NotImplementedException();
        }

        public Card GetCardById(Id<Card> card)
        {
            throw new NotImplementedException();
        }

        public bool HasCard(string cardName)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Deckbuilder.Logic.Interfaces;
using Deckbuilder.Logic.Models;
using Deckbuilder.Common;
using System.Linq;

namespace Deckbuilder.CardSource
{
    public class ParrotCardSource : ICardSource
    {
        private List<Card> _cards { get; set; }

        public ParrotCardSource()
        {
            _cards = new List<Card>();
        }

        public Card GetCard(string cardName)
        {
            if(_cards.Any(c => c.Name.Equals(cardName, StringComparison.InvariantCultureIgnoreCase)))
            {
                return _cards.Find(c => c.Name.Equals(cardName, StringComparison.InvariantCultureIgnoreCase));
            }
            else
            {
                var id = Id<Card>.GetNextId(_cards);
                var card = new Card(id, cardName);
                _cards.Add(card);
                return card;
            }
        }

        public Card GetCardById(Id<Card> cardId)
        {
            return _cards.Find(c => c.Id == cardId);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Deckbuilder.Common;

namespace Deckbuilder.Logic.Models
{
    public class DeckCard
    {
        public int Quantity { get; set; } //enda fältet som skiljer den från en Workspace card, är det bättre att den innehåller en istället? eller är det bara accidental duplication?
        public Id<Card> CardId { get; }
        public List<Id<Tag>> TagIds { get; set; }
        public Id<DeckCard> Id { get; set; }

        public DeckCard(Id<DeckCard> id, Card card, int quantity)
        {
            Id = id;
            CardId = card.Id;
            Quantity = quantity;
        }
    }
}

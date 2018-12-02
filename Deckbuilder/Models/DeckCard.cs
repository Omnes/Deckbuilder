using System;
using System.Collections.Generic;
using System.Text;

namespace Deckbuilder.Models
{
    public class DeckCard
    {
        public Card Card { get; }
        public int Quantity { get; set; }

        public DeckCard(Card card)
        {
            Card = card;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Deckbuilder.Interfaces;
using Deckbuilder.Models;

namespace Deckbuilder.CardSource
{
    public class ParrotCardSource : ICardSource
    {
        public Card GetCard(string cardName)
        {
            return new Card { Name = cardName };
        }
    }
}

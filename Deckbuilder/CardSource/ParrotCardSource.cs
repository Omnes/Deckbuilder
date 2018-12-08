using System;
using System.Collections.Generic;
using System.Text;
using Deckbuilder.Logic.Interfaces;
using Deckbuilder.Logic.Models;
using Deckbuilder.Common;

namespace Deckbuilder.CardSource
{
    public class ParrotCardSource : ICardSource
    {
        public Card GetCard(string cardName)
        {
            Random rnd = new Random();
            var temporaryRandomIdUntilIFindWhereToAcuallyPutTheseCards = new Id<Card>(rnd.Next(1, int.MaxValue));
            return new Card (temporaryRandomIdUntilIFindWhereToAcuallyPutTheseCards, cardName );
        }
    }
}

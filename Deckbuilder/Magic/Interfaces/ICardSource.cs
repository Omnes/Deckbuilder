using System;
using System.Collections.Generic;
using System.Text;
using Deckbuilder.Logic.Models;
using Deckbuilder.Common;

namespace Deckbuilder.Logic.Interfaces
{
    public interface ICardSource
    {
        Card GetCard(string cardName);
        Card GetCardById(CardId cardId);
    }
}

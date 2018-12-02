using System;
using System.Collections.Generic;
using System.Text;
using Deckbuilder.Models;

namespace Deckbuilder.Interfaces
{
    public interface ICardSource
    {
        Card GetCard(string cardName);
    }
}

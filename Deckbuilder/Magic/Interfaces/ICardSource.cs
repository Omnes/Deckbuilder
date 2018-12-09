using System;
using System.Collections.Generic;
using System.Text;
using Deckbuilder.Logic.Models;

namespace Deckbuilder.Logic.Interfaces
{
    public interface ICardSource
    {
        Card GetCard(string cardName);
    }
}

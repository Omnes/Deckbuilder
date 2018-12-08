using System;
using System.Collections.Generic;
using System.Text;
using Deckbuilder.Logic.Models;
using Deckbuilder.Common;

namespace Deckbuilder.Logic.Interfaces
{
    public interface IEntity<T>
    {
        Id<T> Id { get; }
    }
}

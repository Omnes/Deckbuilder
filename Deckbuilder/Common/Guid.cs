using System;
using System.Collections.Generic;
using System.Linq;

namespace Deckbuilder.Common
{
    public class CardId
    {
        public Guid Value { get; }

        public CardId(Guid value)
        {
            Value = value;
        }

        public static bool operator ==(CardId id1, CardId Id2)
        {
            return id1.Value == Id2.Value;
        }

        public static bool operator !=(CardId id1, CardId Id2)
        {
            return id1.Value != Id2.Value;
        }

        public override bool Equals(object obj)
        {
            return obj is CardId id && Value == id.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }
    }
}

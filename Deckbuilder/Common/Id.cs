using System;
using System.Collections.Generic;
using System.Text;

namespace Deckbuilder.Common
{
    public class Id<T>
    {
        public int Value { get; }

        public Id(int value)
        {
            Value = value;
        }

        public static bool operator ==(Id<T> id1, Id<T> Id2)
        {
            return id1.Value == Id2.Value;
        }

        public static bool operator !=(Id<T> id1, Id<T> Id2)
        {
            return id1.Value != Id2.Value;
        }

        public override bool Equals(object obj)
        {
            return obj is Id<T> id && Value == id.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }
    }
}

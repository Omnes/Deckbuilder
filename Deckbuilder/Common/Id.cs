using System;
using System.Collections.Generic;
using System.Linq;

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

#pragma warning disable CS0693 // Type parameter has the same name as the type parameter from outer type
        public static Id<T> GetNextId<T>(IEnumerable<T> collection) where T : IEntity<T>
        {
            if (collection.Any())
                return new Id<T>(collection.Select(e => e.Id.Value).Max() + 1);
            return new Id<T>(0);
        }
#pragma warning restore CS0693 // Type parameter has the same name as the type parameter from outer type
    }
}

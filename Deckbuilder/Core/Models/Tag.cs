using Deckbuilder.Common;

namespace Deckbuilder.Logic.Models
{
    public class Tag : IEntity<Tag>
    {
        public string Name { get; }
        public Id<Tag> Id { get; }

        public Tag(Id<Tag> id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

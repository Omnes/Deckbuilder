namespace Deckbuilder.Common
{
    public interface IEntity<T>
    {
        Id<T> Id { get; }
    }
}

namespace RpgTracker.Domain.Interfaces
{
    public interface IStoredEntity
    {
        string Id { get; }
        string FolderId { get; }
        string Name { get;}
        
    }
}
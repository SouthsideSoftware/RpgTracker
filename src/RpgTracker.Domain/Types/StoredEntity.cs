namespace RpgTracker.Domain.Types
{
    public class StoredEntity
    {
        public string Id { get; set; }
        public string FolderId { get; }
        public string Name { get;}

        public StoredEntity(string folderId, string name)
        {
            FolderId = folderId;
            Name = name;
        }
    }
}
namespace RpgTracker.Storage
{
    public interface IUnitOfWork
    {
        void SaveChangesAsync();
        void StoreAsync(object o);
    }
}
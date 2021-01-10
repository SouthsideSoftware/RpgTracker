namespace RpgTracker.Storage
{
    public interface IUnitOfWork
    {
        void Save();
        void Store(object o);
    }
}
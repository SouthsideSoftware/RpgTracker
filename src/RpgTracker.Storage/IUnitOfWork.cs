using System;

namespace RpgTracker.Storage
{
    public interface IUnitOfWork : IDisposable
    {
        void SaveChangesAsync();
        void StoreAsync(object o);
    }
}
using System;
using System.Threading.Tasks;

namespace RpgTracker.Storage
{
    public interface IUnitOfWork : IDisposable
    {
        Task SaveChangesAsync();
        Task StoreAsync(object o);
    }
}
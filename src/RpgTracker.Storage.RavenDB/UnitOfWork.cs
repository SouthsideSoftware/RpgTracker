using System;
using System.Threading.Tasks;
using Raven.Client.Documents.Session;

namespace RpgTracker.Storage.RavenDB
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly IAsyncDocumentSession session; 
        
        public UnitOfWork(IDatabaseConnection connection)
        {
            session = ((DatabaseConnection) connection).Store.OpenAsyncSession();
        }
        
        public async Task SaveChangesAsync()
        {
            await session.SaveChangesAsync();
        }

        public async Task StoreAsync(object o)
        {
            await session.StoreAsync(o);
        }

        public void Dispose()
        {
            session.Dispose();
        }
    }
}
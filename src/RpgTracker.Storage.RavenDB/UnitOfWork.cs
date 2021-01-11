using System;
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
        
        public async void SaveChangesAsync()
        {
            await session.SaveChangesAsync();
        }

        public async void StoreAsync(object o)
        {
            await session.StoreAsync(o);
        }

        public void Dispose()
        {
            session.Dispose();
        }
    }
}
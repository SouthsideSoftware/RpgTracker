using System;
using Raven.Client.Documents.Session;

namespace RpgTracker.Storage.RavenDB
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IAsyncDocumentSession session; 
        
        public UnitOfWork(IDatabaseConnection connection)
        {
            session = ((DatabaseConnection) connection).Store.OpenAsyncSession();
        }
        
        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Store(object o)
        {
            throw new NotImplementedException();
        }
    }
}
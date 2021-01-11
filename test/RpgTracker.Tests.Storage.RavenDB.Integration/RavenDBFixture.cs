using System;
using RpgTracker.Storage.RavenDB;

namespace RpgTracker.Tests.Integration
{
    public class RavenDBFixture : IDisposable
    {
        public DatabaseConnection DatabaseConnection { get; }
        
        public RavenDBFixture()
        {
            DatabaseConnection = new DatabaseConnection();
        }
        
        public void Dispose()
        {
            DatabaseConnection.DeleteDatabase();
        }
    }
}
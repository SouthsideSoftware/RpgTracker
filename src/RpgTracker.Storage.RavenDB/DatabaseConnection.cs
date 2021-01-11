using System;
using System.Threading.Tasks;
using Raven.Client.Documents;
using Raven.Client.Documents.Operations;
using Raven.Client.Exceptions;
using Raven.Client.Exceptions.Database;
using Raven.Client.ServerWide;
using Raven.Client.ServerWide.Operations;

namespace RpgTracker.Storage.RavenDB
{
    public class DatabaseConnection : IDatabaseConnection
    {
        public IDocumentStore Store { get; }

        public DatabaseConnection()
        {
            IDocumentStore newStore = new DocumentStore()
            {
                // Define the cluster node URLs (required)
                //TODO: Configurable
                Urls = new[] { "http://localhost:8080", 
                    /*some additional nodes of this cluster*/ },

                // Set conventions as necessary (optional)
                Conventions =
                {
                    MaxNumberOfRequestsPerSession = 10,
                    UseOptimisticConcurrency = true
                },

                // Define a default database (optional)
                //TODO: Multi-tenant/configurable
                Database = "RpgTracker",

                // Define a client certificate (optional)
                //Certificate = new X509Certificate2("C:\\path_to_your_pfx_file\\cert.pfx"),

                // Initialize the Document Store
            }.Initialize();

            Store = newStore;
            EnsureDatabaseExists();
        }
        
        public IUnitOfWork OpenUnitOfWorkAsync()
        {
            return new UnitOfWork(this);
        }

        private void EnsureDatabaseExists()
        {
            try
            {
                Store.Maintenance.ForDatabase(Store.Database).Send(new GetStatisticsOperation());
            }
            catch (DatabaseDoesNotExistException)
            {
                try
                {
                    Store.Maintenance.Server.Send(new CreateDatabaseOperation(new DatabaseRecord(Store.Database)));
                }
                catch (ConcurrencyException)
                {
                    // The database was already created before calling CreateDatabaseOperation
                }

            }
        }

        public void DeleteDatabase()
        {
            Store.Maintenance.Server.Send(new DeleteDatabasesOperation("RpgTracker", hardDelete: true,
                fromNode: null, timeToWaitForConfirmation: TimeSpan.FromSeconds(30)));
        }
    }
}
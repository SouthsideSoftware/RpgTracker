using System;
using System.Threading.Tasks;
using Raven.Client.Documents;
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
        }
        
        public IUnitOfWork OpenUnitOfWorkAsync()
        {
            return new UnitOfWork(this);
        }

        public void DeleteDatabase()
        {
            var taskInfo = Store.Maintenance.Server.Send(new DeleteDatabasesOperation("RpgTracker", hardDelete: true,
                fromNode: null, timeToWaitForConfirmation: TimeSpan.FromSeconds(30)));
        }
    }
}
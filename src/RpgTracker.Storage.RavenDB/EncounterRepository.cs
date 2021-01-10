using RpgTracker.Domain.Interfaces;

namespace RpgTracker.Storage.RavenDB
{
    public class EncounterRepository : IEncounterRepository
    {
        private readonly IDatabaseConnection databaseConnection;

        public EncounterRepository(IDatabaseConnection databaseConnection)
        {
            this.databaseConnection = databaseConnection;
        }
        
        public IEncounter Get(string id)
        {
            throw new System.NotImplementedException();
        }

        public IEncounter GetByName(string folderId, string name)
        {
            throw new System.NotImplementedException();
        }

        public void Save(IEncounter encounter)
        {
            throw new System.NotImplementedException();
        }
    }
}
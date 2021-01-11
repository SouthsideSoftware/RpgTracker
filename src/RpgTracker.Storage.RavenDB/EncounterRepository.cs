using RpgTracker.Domain.Interfaces;
using RpgTracker.Domain.Types;

namespace RpgTracker.Storage.RavenDB
{
    public class EncounterRepository : IEncounterRepository
    {
        private readonly IUnitOfWork unitOfWork;

        public EncounterRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        
        public Encounter Get(string id)
        {
            throw new System.NotImplementedException();
        }

        public Encounter GetByName(string folderId, string name)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Encounter encounter)
        {
            unitOfWork.SaveChangesAsync();
        }
    }
}
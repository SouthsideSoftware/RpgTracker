using RpgTracker.Domain.Interfaces;

namespace RpgTracker.Storage
{
    public interface IEncounterRepository
    {
        IEncounter Get(string id);
        IEncounter GetByName(string folderId, string name);
        void Save(IEncounter encounter);
    }
}
using RpgTracker.Domain.Types;

namespace RpgTracker.Storage
{
    public interface IEncounterRepository
    {
        Encounter Get(string id);
        Encounter GetByName(string folderId, string name);
        void Save(Encounter encounter);
    }
}
using System.Collections.Generic;
using RpgTracker.Domain.Types;

namespace RpgTracker.Domain.Interfaces
{
    public interface IEncounter : IStoredEntity
    {
        IList<Combatant> Combatants { get; }
    }
}
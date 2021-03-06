using System;
using System.Collections.Generic;
using RpgTracker.Domain.Interfaces;

namespace RpgTracker.Domain.Types
{
    public class Encounter : StoredEntity
    {
        public IList<Combatant> Combatants { get; }

        public Encounter(string folderId, string name, IList<Combatant> combatants) : base(folderId, name)
        {
            Combatants = combatants;
        }
    }
}
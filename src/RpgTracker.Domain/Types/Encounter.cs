using System;
using System.Collections.Generic;
using RpgTracker.Domain.Interfaces;

namespace RpgTracker.Domain.Types
{
    public class Encounter : IEncounter
    {
        private readonly IList<Combatant> combatants;
        private string id;
        private readonly string name;

        public IList<Combatant> Combatants => combatants;

        public string FolderId { get; }
        public string Name => name;

        public string Id => id;


    }
}
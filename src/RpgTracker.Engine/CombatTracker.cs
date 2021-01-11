using System.Collections.Generic;
using RpgTracker.Domain.Types;

namespace RpgTracker.Engine
{
    public class CombatTracker : ICombatTracker
    {
        private readonly short? currentRound;
        private readonly short? combatantTurnIndex;

        public CombatTracker()
        {
            
        }

        public IList<Combatant> Combatants { get; }

        public short? CurrentRound => currentRound;

        public short? CombatantTurnIndex => combatantTurnIndex;
    }
}
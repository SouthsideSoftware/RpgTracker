using System.Collections.Generic;
using RpgTracker.Domain.Types;

namespace RpgTracker.Engine
{
    public class CombatTracker : ICombatTracker
    {
        private readonly short? currentRound;
        private readonly short? combatantTurnIndex;
        private readonly IList<Combatant> combatants;

        public CombatTracker()
        {
            
        }

        public IList<Combatant> Combatants => combatants;

        public short? CurrentRound => currentRound;

        public short? CombatantTurnIndex => combatantTurnIndex;
    }
}
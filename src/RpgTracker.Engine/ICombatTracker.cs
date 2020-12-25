using System.Collections.Generic;
using RpgTracker.Domain.Types;

namespace RpgTracker.Engine
{
    public interface ICombatTracker
    {
        IList<Combatant> Combatants { get; }

        short? CurrentRound { get; }
        
        short? CombatantTurnIndex { get; }
        
        
    }
}
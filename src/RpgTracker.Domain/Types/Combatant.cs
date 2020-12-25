using RpgTracker.Domain.Interfaces;

namespace RpgTracker.Domain.Types
{
    public class Combatant : ICombatant
    {

        public string Name { get; }
        public IStatBlock StatBlock { get; }
        public bool IsFoe { get; }
        public bool IsParty { get; }
        short? Initiative { get; }
    }
}
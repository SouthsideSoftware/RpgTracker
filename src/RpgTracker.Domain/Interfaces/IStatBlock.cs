using System.Collections.Generic;
using RpgTracker.Domain.Types;

namespace RpgTracker.Domain.Interfaces
{
    public interface IStatBlock : IAbilityScores
    {
        public short Hp { get; set; }
        public DiceSpec HitDice { get; set; }
        public short Ac { get; set; }
        public IList<SpeedType> Speed { get; set; }
        public IAbilityScores Abilities { get; set; }
        public short? InitiativeModifier { get; set; }
        public RoleType InitiativeRoleType { get; set; }
    }
}
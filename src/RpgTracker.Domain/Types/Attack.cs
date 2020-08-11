using System.Collections.Generic;
using RpgTracker.Domain.Interfaces;

namespace RpgTracker.Domain.Types
{
    public class Attack : IAttack
    {
        public DamageType DamageType { get; set; }
        public DiceSpec Damage { get; set; }
        public bool IsMagic { get; set; }
        public IList<AttackModifierType> AttackModifer { get; set; }
        public SavingThrowType SavingThrowType { get; set; }

        public AttackResult AttackOne(IStatBlock opponent)
        {
            throw new System.NotImplementedException();
        }

        public IList<AttackResult> AttackMany(IList<IStatBlock> opponents)
        {
            throw new System.NotImplementedException();
        }
    }
}
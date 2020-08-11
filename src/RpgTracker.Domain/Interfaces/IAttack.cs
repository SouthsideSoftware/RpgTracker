using System.Collections.Generic;
using RpgTracker.Domain.Types;

namespace RpgTracker.Domain.Interfaces
{
    public interface IAttack
    {
        DamageType DamageType { get; set; }
        DiceSpec Damage { get; set; }
        bool IsMagic { get; set; }
        IList<AttackModifierType> AttackModifer { get; set; }
        SavingThrowType SavingThrowType { get; set; }
        AttackResult AttackOne(IStatBlock opponent);
        
        IList<AttackResult> AttackMany(IList<IStatBlock> opponents);
    }
}
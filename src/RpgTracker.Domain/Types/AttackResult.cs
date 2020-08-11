using System.Collections.Generic;

namespace RpgTracker.Domain.Types
{
    public struct AttackResult
    {
        public short RawDamage { get; set; }
        public short AdjustedDamage { get; set; }
        public DamageType DamageType { get; set; }
        public bool IsMagic { get; set; }
        public List<string> Calculations { get; set; }
    }
}
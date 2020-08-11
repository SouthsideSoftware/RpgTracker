namespace RpgTracker.Domain.Types
{
    public struct AttackModifierType
    {
        public short AttackModifier { get; set; }
        public short DamageModifier { get; set; }
        public string ModifierDescription { get; set; }
    }
}
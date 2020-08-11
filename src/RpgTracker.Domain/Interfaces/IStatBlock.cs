using RpgTracker.Domain.Types;

namespace RpgTracker.Domain.Interfaces
{
    public interface IStatBlock
    {
        public short Hp { get; set; }
        public DiceSpec HitDice { get; set; }
        public short Ac { get; set; }
    }
}
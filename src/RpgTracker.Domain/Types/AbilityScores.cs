using RpgTracker.Domain.Interfaces;

namespace RpgTracker.Domain.Types
{
    public class AbilityScores : IAbilityScores
    {
        public short Str { get; set; }
        public short Dex { get; set; }
        public short Con { get; set; }
        public short Int { get; set; }
        public short Wis { get; set; }
        public short Cha { get; set; }
    }
}
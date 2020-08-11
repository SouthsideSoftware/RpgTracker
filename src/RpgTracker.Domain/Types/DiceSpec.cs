namespace RpgTracker.Domain.Types
{
    public struct DiceSpec
    {
        public short NumberOfDice { get; set; }
        public DiceType DiceType { get; set; }
        public short Add { get; set; }
    }
}
namespace RpgTracker.Domain.Interfaces
{
    public interface ICombatant
    {
        string Name { get; }
        IStatBlock StatBlock { get; }
        public bool IsFoe { get; }
        public bool IsParty { get; }
    }
}
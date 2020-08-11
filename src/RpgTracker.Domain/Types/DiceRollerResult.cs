using System.Collections.Generic;

namespace RpgTracker.Domain.Types
{
    public struct DiceRollerResult
    {
        public IList<short> Dice { get; set; }
        public short Total { get; set; }
    }
}
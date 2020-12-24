using DiceNotation;
using Xunit;
using FluentAssertions;
using Xunit.Abstractions;

namespace RpgTracker.Tests.Unit.Engine
{
    public class DiceRollerTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        public DiceRollerTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void CanRollDice()
        {
            var parser = new DiceParser();
            var dice = parser.Parse("3d6+1");
            var result = dice.Roll();
            result.Value.Should().BeGreaterOrEqualTo(2).And.BeLessOrEqualTo(19);
        }
    }
}
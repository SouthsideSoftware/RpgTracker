using System;
using Xunit;
using FluentAssertions;

namespace RpgTracker.Tests.Unit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int x = 1;
            int y = 2;

            var z = x + y;
            z.Should().Be(3);
        }
    }
}
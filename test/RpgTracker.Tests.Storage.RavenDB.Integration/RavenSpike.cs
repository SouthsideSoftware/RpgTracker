using System.Collections.Generic;
using Raven.Client.Documents.Linq;
using RpgTracker.Domain.Types;
using Xunit;

namespace RpgTracker.Tests.Integration
{
    [Collection("RavenDB collection")]
    public class RavenSpike
    {
        private RavenDBFixture fixture;

        public RavenSpike(RavenDBFixture fixture)
        {
            this.fixture = fixture;
        }
        
        [Fact]
        public async void SaveEncounter()
        {
            using var uow = fixture.DatabaseConnection.OpenUnitOfWorkAsync();
            uow.StoreAsync(new Encounter(null, "One", new List<Combatant>()));
            uow.SaveChangesAsync();
        }
        
    }
}
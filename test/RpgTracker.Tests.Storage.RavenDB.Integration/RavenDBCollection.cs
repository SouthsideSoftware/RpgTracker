using Xunit;

namespace RpgTracker.Tests.Integration
{
    [CollectionDefinition("RavenDB collection")]
    public class RavenDBCollection : ICollectionFixture<RavenDBFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
}
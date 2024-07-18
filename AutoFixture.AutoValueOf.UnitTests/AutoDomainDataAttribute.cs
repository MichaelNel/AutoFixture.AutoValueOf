using AutoFixture.Xunit2;

namespace AutoFixture.AutoValueOf.UnitTests;

public class AutoDomainDataAttribute : AutoDataAttribute
{
    public AutoDomainDataAttribute() : base(FixtureFactory.Create)
    {
    }
}
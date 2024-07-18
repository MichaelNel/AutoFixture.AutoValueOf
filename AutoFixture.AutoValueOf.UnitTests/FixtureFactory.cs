namespace AutoFixture.AutoValueOf.UnitTests;

public static class FixtureFactory
{
    public static Fixture Create()
    {
        var fixture = new Fixture();
        fixture.Customizations.Add(new ValueOfSpecimenBuilder());
        return fixture;
    }
}
using AutoFixture.Xunit2;
using Shouldly;
using ValueOf;

namespace AutoFixture.AutoValueOf.UnitTests;

public class ValueOfSpecimenBuilderTests
{
    [Theory]
    [AutoDomainData]
    public void Create_WithCustomization_CreatesValues(IntValue intValue, StringValue stringValue, BoolValue boolValue)
    {
        intValue.Value.ShouldBeOfType<int>();
        intValue.Value.ShouldNotBe(0);
        stringValue.Value.ShouldBeOfType<string>();
        stringValue.Value.ShouldNotBeNullOrWhiteSpace();
        boolValue.Value.ShouldBeOfType<bool>();
    }

    [Theory]
    [AutoData]
    public void Create_WithoutCustomization_CreatesDefaultValue(IntValue intValue, StringValue stringValue,
        BoolValue boolValue)
    {
        intValue.Value.ShouldBe(default);
        stringValue.Value.ShouldBe(default);
        boolValue.Value.ShouldBe(default);
    }
}

public class IntValue : ValueOf<int, IntValue>;

public class BoolValue : ValueOf<bool, BoolValue>;

public class StringValue : ValueOf<string, StringValue>;
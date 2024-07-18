# AutoFixture.AutoValueOf

[![NuGet version](https://buildstats.info/nuget/autovalueof)](https://www.nuget.org/packages/AutoValueOf)

[ValueOf](https://github.com/mcintyre321/ValueOf) customization
for [AutoFixture](https://github.com/AutoFixture/AutoFixture).

## Usage

```csharp
public class UserName : ValueOf<string, UserName>;
```

```csharp
var fixture = new Fixture();
fixture.Customizations.Add(new ValueOfSpecimenBuilder());
var value = fixture.Create<UserName>();
```
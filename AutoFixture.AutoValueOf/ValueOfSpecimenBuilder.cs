using System.Reflection;
using AutoFixture.Kernel;
using ValueOf;

public class ValueOfSpecimenBuilder : ISpecimenBuilder
{
    public object Create(object request, ISpecimenContext context)
    {
        if (request is Type type && IsValueOfSubclass(type))
        {
            var valueOfType = type.BaseType!;
            var valueType = valueOfType.GetGenericArguments()[0];
            var value = context.Resolve(valueType);
            var method = valueOfType.GetMethod("From", BindingFlags.Static | BindingFlags.Public);
            if (method == null) return new NoSpecimen();

            var valueOfInstance = method.Invoke(null, new[] { value });
            return valueOfInstance!;
        }

        return new NoSpecimen();
    }

    private static bool IsValueOfSubclass(Type type)
    {
        var valueOfType = typeof(ValueOf<,>);
        var baseType = type.BaseType;
        return baseType is { IsGenericType: true } && baseType.GetGenericTypeDefinition() == valueOfType;
    }
}
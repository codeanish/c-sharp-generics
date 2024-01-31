# c-sharp-generics
A repo for me to play around with generics

When using functions that accept abstract types and subsequently cast those types to concrete types, it might be a good opportunity to use generics.

## Non-Generics

Functions that accept abstract types as arguments may look like this:

```
public sealed class TypeAUser
{
    public string GetTypeValue(AbstractBaseType myType)
    {
        TypeA typeA = (TypeA)myType;
        return string.Concat(typeA.Name, typeA.MyInt.ToString());
    }
}
```

Clearly, this is not a good situation to be in as this could potentially be called by another implementation of an AbstractBaseType which is not of TypeA. This will cause it to fail at runtime, but still compile at build time.

## Generics

Instead of using a casting of AbstractBaseType's, we can instead create a Generic interface that can be used to implement the function.

```
public interface ITypeUser<T>
{
    string GetTypeValue(T myType);
}

public sealed class TypeAUser : ITypeUser<TypeA>
{
    public string GetTypeValue(TypeA myType)
    {
        return string.Concat(myType.Name, myType.MyInt.ToString());
    }
}
```

This means at build time, we're able to validate that the function GetTypeValue cannot be called by something that is not of TypeA. 
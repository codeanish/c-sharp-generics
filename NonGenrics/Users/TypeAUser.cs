using CodeAnish.CSharpGenerics.NonGenerics.Types;

namespace CodeAnish.CSharpGenerics.NonGenerics.Users
{
    public sealed class TypeAUser
    {
        public string GetTypeValue(AbstractBaseType myType)
        {
            TypeA typeA = (TypeA)myType;
            return string.Concat(typeA.Name, typeA.MyInt.ToString());
        }
    }
}
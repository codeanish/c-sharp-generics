using CodeAnish.CSharpGenerics.NonGenerics.Types;

namespace CodeAnish.CSharpGenerics.NonGenerics.Users
{
    public sealed class TypeBUser
    {
        public string GetTypeValue(AbstractBaseType myType)
        {
            TypeB typeB = (TypeB)myType;
            return string.Concat(typeB.Name, typeB.MyBool.ToString());
        }
    }
}
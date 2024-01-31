using CodeAnish.CSharpGenerics.Generics.Types;

namespace CodeAnish.CSharpGenerics.Generics.Users
{
    public sealed class TypeAUser : ITypeUser<TypeA>
    {
        public string GetTypeValue(TypeA myType)
        {
            return string.Concat(myType.Name, myType.MyInt.ToString());
        }
    }
}
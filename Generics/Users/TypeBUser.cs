using CodeAnish.CSharpGenerics.Generics.Types;

namespace CodeAnish.CSharpGenerics.Generics.Users
{
    public sealed class TypeBUser : ITypeUser<TypeB>
    {
        public string GetTypeValue(TypeB myType)
        {
            return string.Concat(myType.Name, myType.MyBool.ToString());
        }
    }
}
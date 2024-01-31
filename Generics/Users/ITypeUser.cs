namespace CodeAnish.CSharpGenerics.Generics.Users
{
    public interface ITypeUser<T>
    {
        string GetTypeValue(T myType);
    }
}
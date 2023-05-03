namespace Dotnet.Rename;

public static class StringExtensions
{
    public static string ToSlnPathFormat(this string source)
    {
        return source.Replace("/", @"\");
    }
}

public static class ReverseString
{
    public static string Reverse(string input)
    {
        var result = "";
        foreach (var character in input)
        {
            result = character + result;
        }

        return result;
    }
}
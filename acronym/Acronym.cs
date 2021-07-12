using System.Linq;
using System.Text.RegularExpressions;

namespace Acronym
{
    public static class Acronym
    {
        public static string Abbreviate(string phrase)
        {
            const string pattern = "[^a-zA-Z']";
            string[] words = Regex.Split(
                phrase,
                pattern,
                RegexOptions.IgnoreCase
            );
            var filtered = words.Where(word => !string.IsNullOrEmpty(word));
            var result = filtered
                .Aggregate("", (current, word) => current + word[0].ToString().ToUpper());
            return result;
        }
    }
}
using Isogram.Models;

namespace Isogram
{
    public static class Isogram
    {
        public static bool IsIsogram(string word)
        {
            var alphabet = new Alphabet();
            foreach (var letter in word)
            {
                alphabet.AddLetter(letter.ToString());
            }

            var result = alphabet.IsIsogram();
            return result;
        }
    }
}
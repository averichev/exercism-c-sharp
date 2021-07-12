
using Pangram.Models;

namespace Pangram
{
    public static class Pangram
    {
        public static bool IsPangram(string input)
        {
            var alphabet = new Alphabet();
            foreach (var letter in input)
            {
                alphabet.AddLetter(letter.ToString());
            }

            var result = alphabet.IsPangram();
            return result;
        }
    }
}
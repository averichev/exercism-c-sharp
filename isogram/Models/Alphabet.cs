using System.Collections.Generic;
using System.Linq;

namespace Isogram.Models
{
    public class Alphabet
    {
        private readonly Dictionary<string, byte> _value;

        public Alphabet()
        {
            _value = new Dictionary<string, byte>
            {
                {"a", 0},
                {"b", 0},
                {"c", 0},
                {"d", 0},
                {"e", 0},
                {"f", 0},
                {"g", 0},
                {"h", 0},
                {"j", 0},
                {"k", 0},
                {"l", 0},
                {"m", 0},
                {"n", 0},
                {"o", 0},
                {"p", 0},
                {"q", 0},
                {"r", 0},
                {"s", 0},
                {"t", 0},
                {"u", 0},
                {"v", 0},
                {"w", 0},
                {"x", 0},
                {"y", 0},
                {"z", 0}
            };
        }

        public void AddLetter(string letter)
        {
            var lower = letter.ToLower();
            if (!_value.ContainsKey(lower))
            {
                return;
            }

            _value[lower]++;
        }

        public bool IsIsogram()
        {
            var n = _value.Count(b => b.Value > 1);
            var result = n == 0;
            return result;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longest_repeating_character_replacement
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static int CharacterReplacement(string s, int k)
        {
            int left = 0, frequency = 0, result = 0; ;
            IDictionary<char, int> characters = new Dictionary<char, int>();

            for (int right = 0; right < s.Length; right++)
            {
                if (characters.TryGetValue(s[right], out int charFrequency))
                {
                    characters[s[right]] = charFrequency + 1;
                } else
                {
                    characters[s[right]] = 1;
                }

                frequency = Math.Max(frequency, characters[s[right]]);

                while (right - left + 1 - frequency > k)
                {
                    characters[s[left]] -= 1;
                    left++;
                }

                result = Math.Max(result, right - left + 1);
            }

            return result;
        }
    }
}

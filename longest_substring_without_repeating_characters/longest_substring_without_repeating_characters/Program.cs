using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longest_substring_without_repeating_characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LengthOfLongestSubstring("abcabcbb");
        }
        public static int LengthOfLongestSubstring(string s)
        {
            int leftIndex = 0, result = 0;
            // character -> index
            IDictionary<char, int> characterIndex = new Dictionary<char, int>();

            for (int rightIndex = 0; rightIndex < s.Length; rightIndex++)
            {
                if (characterIndex.TryGetValue(s[rightIndex], out int oldIndex) && leftIndex <= oldIndex)
                {
                    leftIndex = oldIndex + 1;
                }
                characterIndex[s[rightIndex]] = rightIndex;
                result = Math.Max(result, rightIndex - leftIndex + 1);
            }

            return result;
        }
    }
}

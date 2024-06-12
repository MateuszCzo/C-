using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roman_to_integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RomanToInt("MCMXCIV");
        }

        private static IDictionary<char, int> romanDictionary = new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public static int RomanToInt(string s)
        {
            int number = 0;

            for (int i = 0; i < s.Length; i++)
            {
                romanDictionary.TryGetValue(s[i], out int num);

                if (i + 1 < s.Length &&
                    romanDictionary.TryGetValue(s[i + 1], out int nextNumber) &&
                    num < nextNumber)
                {
                    number += nextNumber - num;
                    i++;
                    continue;
                }

                number += num;
            }

            return number;
        }
    }
}

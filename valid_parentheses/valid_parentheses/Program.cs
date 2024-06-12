using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valid_parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public bool IsValid(string s)
        {
            IDictionary<char, char> dictionary = new Dictionary<char, char> {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' },
            };
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dictionary.TryGetValue(s[i], out char character))
                {
                    if (stack.Count == 0 || stack.Pop() != character)
                    {
                        return false;
                    }
                } else
                {
                    stack.Push(s[i]);
                }
            }
            if (stack.Count != 0)
            {
                return false;
            }
            return true;
        }
    }
}

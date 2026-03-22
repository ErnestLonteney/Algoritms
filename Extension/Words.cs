using System;
using System.Collections.Generic;
using System.Text;

namespace Extension
{
    static class Words
    {
        public static string MySubstring(this string word, int startSymbol, int length)
        {
            string result = " ";

            for (int i = startSymbol; i < startSymbol + length; i++)
            {
                result += word[i];
            }

            return result;
        }

        public static string MySubstring(this string word, int startSymbol)
        {
            string result = " ";

            for (int i = startSymbol; i < word.Length; i++)
            {
                result += word[i];
            }

            return result;
        }
    }
}

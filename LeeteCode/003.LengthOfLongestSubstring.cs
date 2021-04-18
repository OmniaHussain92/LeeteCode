using System;
using System.Collections.Generic;

namespace LeeteCode
{
    public static class _3LengthOfLongestSubstring
    {
        public static int LengthOfLongestSubstring1(string s)
        {
            int length = s.Length;
            if (length == 0)
            {
                return 0;
            }

            int longestLen = 0;
            var set = new HashSet<Char>();
            int i = 0, j = 1;

            while (i < length && j < length)
            {
                if (set.Contains(s[j]))
                {
                    set.Remove(s[i++]);
                }
                else
                {
                    set.Add(s[j++]);
                    longestLen = Math.Max(longestLen, j - i);
                }
            }

            return longestLen;
        }
    }
}

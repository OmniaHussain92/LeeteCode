using System;
using System.Collections.Generic;
using System.Text;

namespace LeeteCode
{
   public class LongestCommonPrefix
    {
        public string GetLongestCommonPrefix(string[] strs)
        {
            string common = string.Empty;
            int strsLen = strs.Length;

            if (strsLen < 1)
                return common;

            char currChar;

            for (int currIndex = 0; currIndex < strs[0].Length; currIndex++)
            {
                currChar = strs[0][currIndex];

                for (int i = 1; i < strsLen; i++)
                {
                    if (strs[i].Length <= currIndex || strs[i][currIndex] != currChar)
                    {
                        return common;
                    }
                }

                common += currChar.ToString();
            }

            return common;
        }
    }
}

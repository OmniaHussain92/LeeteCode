using System;
using System.Collections.Generic;
using System.Text;

namespace LeeteCode
{
    public class LongestPalaindromicSubstring
    {
        public string LongestPalindrome_BruteForce(string s)
        {
            int maxPalLen = 1; int startPos = 0;
            int len = s.Length;
            bool isPalin = true;
            int curSubLen = 1;

            for (int i = 0; i < len; i++)
            {
                for (int j = i; j < len; j++)
                {
                    isPalin = true;

                    curSubLen = j - i + 1;

                    // check if not pal
                    for (int x = 0; x < curSubLen / 2; x++)
                    {
                        if (s[x + i] != s[j - x])
                        {
                            isPalin = false;
                            break;
                        }
                    }

                    if (isPalin && curSubLen > maxPalLen)
                    {
                        maxPalLen = curSubLen;
                        startPos = i;
                        Console.WriteLine("index is " + i + " & length is " + maxPalLen);
                    }

                }
            }

            string result = string.Empty;
            for (int i = startPos; i < startPos + maxPalLen; i++)
            {
                result += s[i];
            }
            return result;
        }
        public string LongestPalindrome_DP(string s)
        {
            int len = s.Length;
            int[,] mem = new int[len, len];
            for (int i = 0; i < len; i++)
            {
                mem[i, i] = 1;
            }

            int maxlen = 1;
            int startInd = 0;
            for (int i = 0; i < len - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    maxlen = 2;
                    mem[i, i + 1] = 1;
                    startInd = i;
                }
            }

            int end = 0; int endSub = 0;
            for (int k = 3; k <= len; k++)
            { // equal to match last char
                end = len - k + 1;

                for (int i = 0; i < end; i++)
                {
                    endSub = i + k - 1;
                    if (mem[i + 1, endSub - 1] == 1 && s[i] == s[endSub])
                    {
                        mem[i, endSub] = 1;
                        //Console.Write(" match :" + i);
                        if (k > maxlen)
                        {
                            maxlen = k;
                            startInd = i;
                        }
                    }
                }
            }


            string result = string.Empty;
            for (int i = startInd; i < startInd + maxlen; i++)
            {
                result += s[i];
            }
            return result;
        }
    }
}

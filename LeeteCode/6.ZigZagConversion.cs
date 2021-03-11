using System;
using System.Collections.Generic;
using System.Text;

namespace LeeteCode
{
    public class ZigZagConversion
    {
        // Looping through the string and saving each char in its appropriate row
        public string Convert(string s, int numRows)
        {
            int slength = s.Length;
            if(slength < 1)
            {
                return string.Empty;
            }

            if(slength == 1 ||slength == numRows || numRows == 1)
            {
                return s;
            }

            
            int rows = Math.Min(numRows, slength);
            var lines = new string[rows];
            int lineNum = 0; bool incrementLine = false;
            foreach (var ch in s)
            {
                lines[lineNum] += ch.ToString();
                if(lineNum == 0 || lineNum == rows-1)
                {
                    incrementLine = !incrementLine;
                }
                lineNum = incrementLine ? lineNum + 1 : lineNum - 1;

            }

            string output = string.Empty;
            foreach (var line in lines)
            {
                output += line;
            }

            return output;

        }
    }
}

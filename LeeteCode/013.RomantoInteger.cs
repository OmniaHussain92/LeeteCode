using System.Collections.Generic;

namespace LeeteCode
{
    public class RomantoInteger
    {
        public int RomanToInt(string s)
        {

            // Rules from problem discription
            Dictionary<string, int> map = new Dictionary<string, int>()
            {
                {"M", 1000 },
                {"CM", 900 },
                {"D", 500 },
                {"CD", 400 },
                {"C", 100 },
                {"XC", 90 },
                {"L", 50 },
                {"XL", 40},
                {"X", 10 },
                {"IX", 9 },
                {"V", 5 },
                {"IV", 4 },
                {"I", 1 }
           };

            int number = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var curr = s[i].ToString();
                if (i < s.Length - 1 && (curr == "I" || curr == "X" || curr == "C"))
                {
                    var sub = curr + s[i + 1];
                    if (map.ContainsKey(sub))
                    {
                        number += map[sub];
                        i++;
                        continue;
                    }

                }

                number += map[curr];

            }

            return number;
        }
    }
}

using System.Collections.Generic;

namespace LeeteCode
{
    public class LetterCombinationPhone
    {
        List<string> phoneMap = new List<string>()
        {
          "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv","wxyz"
        };

        public IList<string> LetterCombinations_rec(string digits)
        {

            if (string.IsNullOrEmpty(digits))
            {
                return new List<string>();
            }

            var output = new List<string>();

            GetCombinations(output, digits, 0, "");

            return output;

        }
        private void GetCombinations(List<string> prevCombinations, string digits,
                                   int curIndex, string currStr)
        {
            if (curIndex == digits.Length)
            {
                prevCombinations.Add(currStr);
                return;
            }

            foreach (var item in phoneMap[digits[curIndex] - '0'])
            {

                GetCombinations(prevCombinations, digits, curIndex + 1, currStr + item);
            }
        }

        public IList<string> LetterCombinations_loop(string digits)
        {

            if (string.IsNullOrEmpty(digits))
            {
                return new List<string>();
            }

            var output = new List<string>() { "" };
            var phoneMap = new Dictionary<char, List<char>>()
            {
                {'2', new List<char>(){'a', 'b', 'c'}},
                {'3', new List<char>(){'d', 'e', 'f'}},
                {'4', new List<char>(){'g', 'h', 'i'}},
                {'5', new List<char>(){'j', 'k', 'l'}},
                {'6', new List<char>(){'m', 'n', 'o'}},
                {'7', new List<char>(){'p', 'q', 'r','s'}},
                {'8', new List<char>(){'t', 'u', 'v'}},
                {'9', new List<char>(){'w', 'x', 'y','z'}}
            };

            for (int i = 0; i < digits.Length; i++)
            {
                var newPoss = new List<string>();
                foreach (var item in phoneMap[digits[i]])
                {
                    foreach (var outItem in output)
                    {
                        newPoss.Add(outItem + item);
                    }
                }

                output = newPoss;
            }

            return output;

        }
    }
}

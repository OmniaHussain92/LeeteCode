using System.Collections.Generic;
using System.Text;

namespace LeeteCode
{
    public class IntegertoEnglishWords
    {
        Dictionary<int, string> numbers = new Dictionary<int, string>(){
            {0, "Zero"}, {1,  "One"}, {2, "Two"}, {3,  "Three"},
            {4, "Four"}, {5, "Five"}, {6, "Six"}, {7,"Seven"},
            {8, "Eight"}, {9,"Nine"}, {10,"Ten"}, {11, "Eleven"},
            {12, "Twelve"}, {13, "Thirteen"}, {14, "Fourteen"},
            {15, "Fifteen"}, {16,"Sixteen"},
            {17, "Seventeen"},{18, "Eighteen"},{19, "Nineteen"},
            {20, "Twenty"}, {30, "Thirty"}, {40,"Forty" },
            {50, "Fifty"}, {60, "Sixty"}, {70, "Seventy"},
            {80, "Eighty"}, {90, "Ninety"}
        };

        public string NumberToWords(int num)
        {

            if (numbers.ContainsKey(num))
            {
                return numbers[num];
            }

            StringBuilder output = new StringBuilder();
            int remain = 0;
            if (num >= 1000000000)
            {
                remain = num / 1000000000;
                var countStr = GetRemain(remain);
                output.Append(countStr + " Billion");
                num = num % 1000000000;
            }

            if (num >= 1000000)
            {
                remain = num / 1000000;
                var countStr = GetRemain(remain);
                output.Append(countStr + " Million");
                num = num % 1000000;
            }

            if (num >= 1000)
            {
                remain = num / 1000;
                var countStr = GetRemain(remain);
                output.Append(countStr + " Thousand");
                num = num % 1000;
            }

            if (num > 0)
            {
                output.Append(GetRemain(num));
            }
            return output.ToString().Trim();

        }

        public string GetRemain(int num)
        {

            if (numbers.ContainsKey(num))
            {
                return " " + numbers[num];
            }
            StringBuilder output = new StringBuilder();
            if (num >= 100)
            {
                int remain = num / 100;
                output.Append(" " + numbers[remain] + " Hundred");
                num = num % 100;
            }

            if (num > 0)
            {
                if (numbers.ContainsKey(num))
                {
                    output.Append(" " + numbers[num]);
                }
                else
                {

                    int tenNumber = num / 10;
                    output.Append(" " + numbers[tenNumber * 10]);

                    int singleNum = num % 10;
                    output.Append(" " + numbers[singleNum]);
                }
            }

            return output.ToString();
        }
    }
}

using System;

namespace LeeteCode
{
    public class StringtoInteger_atoi
    {
        public int MyAtoi(string s)
        {
            s = s.Trim();

            if (s.Length == 0) return 0;

            bool isNegative = s[0] == '-';
            int iter = isNegative ? 1 : s[0] == '+' ? 1 : 0;

            string str = string.Empty;
            int num = 0;
            while (iter < s.Length && s[iter] >= '0' && s[iter] <= '9')
            {
                if(num > Int32.MaxValue/10 || (num == Int32.MaxValue/10 && s[iter] - '0' > Int32.MaxValue % 10))
                {
                    return isNegative ? Int32.MinValue : Int32.MaxValue;
                }
                num = num * 10 + (s[iter] - '0');

                iter++;
            }

            return isNegative ? (-1)*num : num;
        }
        public int MyAtoi_str(string s)
        {
            s = s.Trim();

            if (s.Length == 0) return 0;

            bool isNegative = s[0] == '-';
            int iter = isNegative ? 1 : s[0] == '+' ? 1 : 0;

            string str = string.Empty;
            while (iter < s.Length)
            {
                if (Char.IsDigit(s[iter]))
                {
                    str += s[iter].ToString();
                    iter++;
                }
                else
                {
                    break;
                }
            }

            if (str.Length == 0) return 0;

            int num = 0;
            if (Int32.TryParse(str, out num))
            {
                return isNegative ? (-1) * num : num;
            }
            return isNegative ? Int32.MinValue : Int32.MaxValue;
        }
    }
}

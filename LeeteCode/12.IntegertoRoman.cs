using System;
using System.Collections.Generic;
using System.Text;

namespace LeeteCode
{
    public class IntegertoRoman
    {
        public string IntToRoman(int num)
        {
            // Rules from problem discription
            string[] roman = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] nums = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

           
            StringBuilder finaleRoman = new StringBuilder();

            for (int i = 0; i < 13; i++)
            {
                while (nums[i] <= num)
                {
                    finaleRoman.Append(roman[i]);
                    num -= nums[i];
                }
            }

            return finaleRoman.ToString();

        }
    }
}

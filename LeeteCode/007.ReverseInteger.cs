using System;

namespace LeeteCode
{
    public class ReverseInteger
    {
        public int Reverse_UsingString(int x)
        {
            

            if ((x >= 0 && x < 10) || (x < 0 && x > -10))
            {
                return x;
            }

            string xStr = Math.Abs((long)x).ToString();
            string xRev = x > 0 ? string.Empty : "-";
            int xStrLen = xStr.Length - 1;
            for (int i = xStrLen; i >= 0; i--)
            {
                xRev += xStr[i].ToString();
            }

            int xout;
            if (Int32.TryParse(xRev, out xout))
                return xout;
            return 0;
        }

        public int Reverse_Mod(int x)
        {
            // check for zero and single digit numbers to return without and calculations
            if ((x >= 0 && x < 10) || (x < 0 && x > -10))
            {
                return x;
            }

            if (x == Int32.MinValue || x == Int32.MaxValue - 1)
            {
                return 0;
            }

            int xout = 0;
            int pop = 0;
            int maxOver = Int32.MaxValue / 10;
            int modMax = Int32.MaxValue % 10;
            int minOver = Int32.MinValue / 10;
            int modMin = Int32.MinValue % 10;
            while (x != 0)
            {
                if (xout > maxOver || xout < minOver)
                    return 0;

                pop = x % 10;

                if ((xout == maxOver && pop >= modMax) || (xout == minOver && pop <= modMin))
                    return 0;

                x /= 10;
                xout = xout * 10 + pop;
            }
            return xout;

        }
    }
}

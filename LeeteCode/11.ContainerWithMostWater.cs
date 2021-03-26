using System;
using System.Collections.Generic;
using System.Text;

namespace LeeteCode
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int max = 0;
            int leftPtr = 0;
            int rightPtr = height.Length - 1;

            while (leftPtr < rightPtr)
            {
                int leftHeight = height[leftPtr];
                int rightHeight = height[rightPtr];

                if (leftHeight < rightHeight)
                {
                    max = Math.Max(leftHeight * (rightPtr - leftPtr), max);
                    leftPtr++;
                }
                else
                {

                    max = Math.Max(rightHeight * (rightPtr - leftPtr), max);
                    rightPtr--;
                }
            }

            return max;
        }
    }
}

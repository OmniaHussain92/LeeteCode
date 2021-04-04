using System;

namespace LeeteCode
{
    public class _016_3Sum_Closest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {

            int numsLen = nums.Length;

            if (numsLen < 3)
            {
                return 0;
            }

            Array.Sort(nums);
            int diff = Int32.MaxValue; int closestSum = 0;
            int left = 0; int right = 0; int curSum = 0;
            for (int i = 0; i < numsLen - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                left = i + 1;
                right = numsLen - 1;

                while (left < right)
                {
                    curSum = nums[i] + nums[left] + nums[right];
                    if (curSum == target)
                    {
                        return curSum;
                    }
                    if (Math.Abs(curSum - target) < diff)
                    {
                        diff = Math.Abs(curSum - target);
                        closestSum = curSum;
                    }
                    if (curSum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }

                }

            }

            return closestSum;

        }
    }
}

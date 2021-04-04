using System;
using System.Collections.Generic;

namespace LeeteCode
{
    class _015ThreeSum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            int numsLen = nums.Length;

            if (numsLen < 3)
            {
                return new List<IList<int>>();
            }


            IList<IList<int>> res = new List<IList<int>>();

            Array.Sort(nums);

            int left = 0; int right = 0; int sum = 0;
            for (int i = 0; i < numsLen - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                left = i + 1;
                right = numsLen - 1;
                while (left < right)
                {
                    sum = nums[i] + nums[left] + nums[right];

                    if (sum == 0)
                    {
                        res.Add(new List<int>() { nums[i], nums[left], nums[right] });
                        left++;

                        while (left < right && nums[left] == nums[left - 1]) left++;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }

            }

            return res;

        }
    }
}

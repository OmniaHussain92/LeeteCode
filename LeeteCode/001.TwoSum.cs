using System;
using System.Collections.Generic;
using System.Text;

namespace LeeteCode
{
    public class TwoSum
    {
        public int[] GetTwoSum(int[] nums, int target)
        {
            return OnePassHash(nums, target);
        }

        /// <summary>
        /// Brute force solution with O(n^2) time complexity andO(1) space 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] BruteForce(int[] nums, int target)
        {
            int[] outArr = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                outArr[0] = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        outArr[1] = j;
                        return outArr;
                    }
                }
            }

            return null;
        }


        /// <summary>
        /// Two pass Hash table with O(n) time complexity and O(n) Space
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoPassDictionary(int[] nums, int target)
        {
            var numsHash = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                numsHash.Add(nums[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (numsHash.ContainsKey(complement) && numsHash[complement] != i)
                {
                    return new int[2] { i, numsHash[complement] };
                }
            }

            throw new InvalidOperationException("No two sum solution");
        }

        /// <summary>
        /// One path hash table with O(n) time and O(n) space complexity
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] OnePassHash(int[] nums, int target)
        {
            var numsHash = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (numsHash.ContainsKey(complement))
                {
                    return new int[2] { i, numsHash[complement] };
                }

                numsHash.Add(nums[i], i);
            }

            throw new InvalidOperationException("No two sum solution");
        }
    }
}

namespace LeeteCode
{
    public static class _4MedianOfTwoSortedArrays
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int arr1Len = nums1.Length;
            int arr2Len = nums2.Length;

            int itemsCount = arr1Len + arr2Len;
            bool isOdd = !((itemsCount % 2) == 0);
            int medianIndex1 = itemsCount / 2;
            int medianIndex2 = !isOdd ? medianIndex1 - 1 : -1;
            int arr1It = 0; int arr2It = 0; int mergedIt = 0;
            int[] mergedArr = new int[itemsCount];

            while (arr1It < arr1Len || arr2It < arr2Len)
            {
                if (arr1It >= arr1Len)
                {
                    mergedArr[mergedIt++] = nums2[arr2It++];
                }
                else if (arr2It >= arr2Len)
                {
                    mergedArr[mergedIt++] = nums1[arr1It++];
                }
                else if (nums1[arr1It] > nums2[arr2It])
                {
                    mergedArr[mergedIt++] = nums2[arr2It++];
                }
                else
                {
                    mergedArr[mergedIt++] = nums1[arr1It++];
                }
            }

            return isOdd ? mergedArr[medianIndex1] : (mergedArr[medianIndex1] + mergedArr[medianIndex2]) / 2;

        }
    }
}

namespace Algorithms_CS.Problems
{
    // There is an integer array nums sorted in ascending order (with distinct values).
    // Prior to being passed to your function, nums is possibly rotated at an unknown index.
    // Given the array nums after the possible rotation and an integer target,
    // return the index of target if it is in nums, or -1 if it is not in nums.
    // Must write an algorithm with O(log n) runtime complexity.
    //
    // Example 1:
    // Input: nums = [4,5,6,7,0,1,2], target = 0
    // Output: 4
    //
    // Example 2:
    // Input: nums = [4,5,6,7,0,1,2], target = 3
    // Output: -1
    //
    // Example 3:
    // Input: nums = [1], target = 0
    // Output: -1
    public class SearchinRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length-1;
            int m;
            while(r - l >= 0)
            {
                m = l + (r - l) / 2;

                if (nums[m] == target) return m;

                if (nums[l] <= nums[m])
                {
                    if (nums[l] <= target && nums[m] >= target)
                    {
                        r = m - 1;
                    }
                    else
                    {
                        l = m + 1;
                    }
                }
                else
                {
                    if (nums[m] <= target && nums[r] >= target)
                    {
                        l = m + 1;
                    }
                    else
                    {
                        r = m - 1;
                    }
                }
            }
            return -1;
        }
    }
}

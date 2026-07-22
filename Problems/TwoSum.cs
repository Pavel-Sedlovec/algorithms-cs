namespace Algorithms_CS.Problems
{
    // Given an array of integers nums and an integer target,
    // return indices of the two numbers such that they add up to target.
    // You may assume that each input would have exactly one solution,
    // and you may not use the same element twice.
    // You can return the answer in any order.
    //
    // Example 1:
    // Input: nums = [2,7,11,15], target = 9
    // Output: [0,1]
    // Explanation: nums[0] + nums[1] == 9, return [0, 1].
    //
    // Example 2:
    // Input: nums = [3,2,4], target = 6
    // Output: [1,2]
    //
    // Example 3:
    // Input: nums = [3,3], target = 6
    // Output: [0,1]
    public class TwoSum
    {
        public int[] SearchTwoSum(int[] nums, int target)
        {
            int[] arr = new int[2];
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dictionary.ContainsKey(target - nums[i]))
                {
                    arr[0] = i;
                    arr[1] = dictionary[target - nums[i]];
                    break;
                }
                if (!dictionary.ContainsKey(nums[i]))
                    dictionary.Add(nums[i],i);
            }
            return arr;
        }
    }
}

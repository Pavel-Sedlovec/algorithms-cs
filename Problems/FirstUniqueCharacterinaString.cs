namespace Algorithms_CS.Problems
{
    // Given a string s, find the first non-repeating character in it
    // and return its index. If it does not exist, return -1.
    //
    // Example 1:
    // Input: s = "leetcode"
    // Output: 0
    // Explanation: The character 'l' at index 0 is the first character
    // that does not occur at any other index.
    //
    // Example 2:
    // Input: s = "loveleetcode"
    // Output: 2
    //
    // Example 3:
    // Input: s = "aabb"
    // Output: -1
    public class FirstUniqueCharacterinaString
    {
        public int FirstUniqChar(string s)
        {
            int[] arr = new int[256];
            for (int i = 0; i < s.Length; i++)
            {
                arr[s[i]]++;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (arr[s[i]] == 1)
                    return i;
            }
            return -1;
        }
    }
}

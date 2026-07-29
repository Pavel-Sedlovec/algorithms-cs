namespace Algorithms_CS.Problems
{
    // Given a string s, find the length of the longest substring without duplicate characters.
    //
    // Example 1:
    // Input: s = "abcabcbb"
    // Output: 3
    // Explanation: The answer is "abc", with the length of 3.
    // Note that "bca" and "cab" are also correct answers.
    //
    // Example 2:
    // Input: s = "bbbbb"
    // Output: 1
    // Explanation: The answer is "b", with the length of 1.
    //
    // Example 3:
    // Input: s = "pwwkew"
    // Output: 3
    // Explanation: The answer is "wke", with the length of 3.
    // Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            bool[] set = new bool[256];

            int maxSubstr = 0;
            int currentSubstr = 0;
            int l = 0; int r = 0;

            while(r < s.Length)
            {
                if (!set[s[r]])
                {
                    set[s[r++]] = true;
                    currentSubstr++;
                }
                else
                {
                    if(currentSubstr > maxSubstr)
                        maxSubstr = currentSubstr;

                    set[s[l++]] = false;
                    currentSubstr--;

                }
            }

            if (currentSubstr > maxSubstr)
                maxSubstr = currentSubstr;
            return maxSubstr;
        }
    }
}

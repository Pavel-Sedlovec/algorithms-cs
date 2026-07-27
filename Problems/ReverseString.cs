namespace Algorithms_CS.Problems
{
    // Write a function that reverses a string.
    // The input string is given as an array of characters s.
    // You must do this by modifying the input array in-place with O(1) extra memory.
    //
    // Example 1:
    // Input: s = ["h","e","l","l","o"]
    // Output: ["o","l","l","e","h"]
    //
    // Example 2:
    // Input: s = ["H","a","n","n","a","h"]
    // Output: ["h","a","n","n","a","H"]
    public class ReverseStr
    {
        public void ReverseString(char[] s)
        {
            int l = 0;
            int r = s.Length - 1;
            while(r-l >= 0)
            {
                char temp = s[r];
                s[r] = s[l];
                s[l] = temp;
                l++;
                r--;
            }
        }
    }
}

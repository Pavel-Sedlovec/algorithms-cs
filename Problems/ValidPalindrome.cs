namespace Algorithms_CS.Problems
{
    // A phrase is a palindrome if, after converting all uppercase letters to lowercase
    // and removing all non-alphanumeric characters, it reads the same forward and backward.
    // Alphanumeric characters include letters and numbers.
    // Given a string s, return true if it is a palindrome, or false otherwise.
    //
    // Example 1:
    // Input: s = "A man, a plan, a canal: Panama"
    // Output: true
    // Explanation: "amanaplanacanalpanama" is a palindrome.
    //
    // Example 2:
    // Input: s = "race a car"
    // Output: false
    // Explanation: "raceacar" is not a palindrome.
    //
    // Example 3:
    // Input: s = " "
    // Output: true
    // Explanation: s is an empty string "" after removing non-alphanumeric characters.
    // Since an empty string reads the same forward and backward, it is a palindrome.
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            int l = 0;
            int r = s.Length - 1;

            while (r - l > 0)
            {
                if (!IsValidChar(s[l])) { l++; continue; }
                if (!IsValidChar(s[r])) { r--; continue; }

                int res = Math.Abs(s[l] - s[r]);

                if (res == 0 || (res == 32 && s[l] >= 65 && s[r] >= 65))
                {
                    l++;
                    r--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsValidChar(char c)
        {
            bool isDigit = c >= 48 && c <= 57;
            bool isUpper = c >= 65 && c <= 90;
            bool isLower = c >= 97 && c <= 122;

            return isDigit || isUpper || isLower;
        }
    }
}

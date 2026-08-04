namespace Algorithms_CS.Problems
{
    // You are given an m x n integer matrix with the following two properties:
    // 1. Each row is sorted in non-decreasing order.
    // 2. The first integer of each row is greater than the last integer of the previous row.
    // Given an integer target, return true if target is in matrix or false otherwise.
    // Must write a solution with O(log(m * n)) time complexity.
    //
    // Example 1:
    // Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 3
    // Output: true
    //
    // Example 2:
    // Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 13
    // Output: false
    public class Searcha2DMatrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int l = 0;
            int r = -1;
            int row = 0;

            int lRow = 0;
            int rRow = matrix.Length-1;

            while (rRow >= lRow)
            {
                int mRow = lRow + (rRow - lRow) / 2;
                int endArr = (matrix[mRow].Length) - 1;
                if (matrix[mRow][0] <= target && matrix[mRow][endArr] >= target)
                {
                    r = endArr;
                    row = mRow; break;
                }
                if(matrix[mRow][0] > target)               
                    rRow = mRow - 1;               
                else if(matrix[mRow][endArr] < target)               
                    lRow = mRow + 1;
                
            }
            while(r >= l)
            {
                int m = l + (r - l) / 2;
                if (matrix[row][m] == target) return true;
                if(matrix[row][m] > target)                
                    r = m - 1;                
                else               
                    l = m + 1;                
            }

            return false;
        }
    }
}

namespace Algorithms_CS.Problems
{
    public class MoveZero
    {
        public void MoveZeroes(int[] nums)
        {
            int indexInsert = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[indexInsert];
                    nums[indexInsert++] = temp;
                }
            }
        }
    }
}

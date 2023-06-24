public class Solution283 {
    public void MoveZeroes(int[] nums) {

        int zeroes = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                (nums[zeroes], nums[i]) = (nums[i], nums[zeroes]);
                zeroes++;
            }
        }
        
    }
}
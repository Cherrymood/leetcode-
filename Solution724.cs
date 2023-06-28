public class Solution724 {
    public int PivotIndex(int[] nums)
    {
        var sumRight = nums.Sum();
        var sumLeft = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sumRight -= nums[i];

            if (sumLeft == sumRight)
            { 
                return i;
            }

            sumLeft += nums[i];
        }

        return -1;
    }
}
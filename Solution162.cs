public class Solution162 {
    public int FindPeakElement(int[] nums) {
        
        int ind = 0;

        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i-1] < nums[i])
            {
                if(i + 1 >= nums.Length || nums[i+1] < nums[i])
                {
                    ind = i;
                }
            }
        }
        return ind;
    }
}

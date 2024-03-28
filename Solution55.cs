public class Solution55 {
    public bool CanJump(int[] nums) {
        
        int ind = nums.Length -1;

        for(int i = nums.Length -1; i >= 0; i--)
        {
            if(i + nums[i] >= ind)
            {
                if(i == 0) return true;
                ind = i;
            }
        }
        
        return false;
    }
}

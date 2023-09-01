public class Solution215 {

    public int FindKthLargest (int[] nums, int k) {
        
        var maxNum = -2147483648;
        var index = 0;
        var tryes = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            
            if (maxNum < nums[i])
            {
                maxNum = nums[i];
                index = i;
            }
            if (tryes == k -1 && i == nums.Length -1)
            {
                return maxNum;
            }
            
            if (i == nums.Length -1)
            {
                nums[index] = -2147483648;
                maxNum = -2147483648;
                tryes++;
                i = -1;
            }
        }
        return maxNum;

    }
}
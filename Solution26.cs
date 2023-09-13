public class Solution26 {
    public int RemoveDuplicates(int[] nums) {

        var i = 1;
        
        foreach (int n in nums)
        {
            if (nums[i-1] != n)
            {
                nums[i++] = n;
            }
        }

        return i;

    }
}
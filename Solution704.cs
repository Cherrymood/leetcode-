public class Solution704 {
    public int Search(int[] nums, int target) {
        
        var start = 0;
        var end = nums.Length - 1;

        while(start <= end)
        {
            int index = start + (end - start) / 2;
        
            if(nums[index] == target)
            {
                return index;
            }

            if(nums[index] > target)
            {
                end = index - 1;
            }

            else
            {
                start = index + 1;
            }
        }
        return -1;
    }
}

public class Solution153 {
    public int FindMin(int[] nums) {

        int start = 0;
        int end = nums.Length - 1;

        while(start < end)
        {
            int mid = start + (end - start) / 2;

            if(mid-1 >= 0 && nums[mid-1] > nums[mid]) 
            {
                return nums[mid];
            }

            if(nums[mid] > nums[end]) 
            {
                start = mid + 1;
            }
            else
            {
                end = mid;
            }
        }
        return nums[start];
    }
}

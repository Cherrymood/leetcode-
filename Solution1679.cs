public class Solution1679 {
    public int MaxOperations(int[] nums, int k) {

        var count = 0;
        var left = 0;
        var right = nums.Length -1;

        Array.Sort(nums);

        while (left < right)
        {
            var sum = nums[left] + nums[right];

            if (sum > k)
            {
                right--;
            }

            if (sum < k)
            {
                left++;
            }

            if (sum == k)
            {
                count++;
                right--;
                left++;

            }
        }
        return count;

        
    }
}

public class Solution1913 {
    public int MaxProductDifference(int[] nums) {

        Array.Sort(nums);

        return  (nums[nums.Length -2] * nums[nums.Length - 1]) - (nums[0] * nums[1]);

    }
}
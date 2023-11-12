public class Solution1 {
    public int[] TwoSum(int[] nums, int target) {
        
        var dict = new Dictionary<int,int> ();

        for (int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];
            if (dict.ContainsKey(diff))
            {
                return new int[]{dict[diff], i};
            }
            else
            {
                dict[nums[i]] = i;
            }
        }

        return null;
    }
}
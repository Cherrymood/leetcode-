public class Solution167 {
    public int[] TwoSum(int[] nums, int target) {
        
        var ans = new int[2];

        var dict = new Dictionary<int,int>();       

        for(int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];

            if(dict.ContainsKey(diff))
            {
                ans[0] = dict[diff]+1;
                ans[1] = i + 1;
            }
            else
            {
                dict[nums[i]] = i;
            }
        }
        return ans;
    }
}

public class Solution {
    public IList<int> TargetIndices(int[] nums, int target) {  

        var ans = new List<int>();

        Array.Sort(nums);
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == target)
            {
                ans.Add(i);
            }

            if(nums[i] != target && ans.Count != 0)
            {
                break;
            }
        }

        return ans;
    }
}

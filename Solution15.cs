public class Solution {
    public void twoSum(int[] nums, int i, List<IList<int>> res)
    {
        var seen = new HashSet<int>();

        for (int j = i+1; j < nums.Length; ++j)
        {
            int diff = -nums[i] - nums[j];
            if (seen.Contains(diff))
            {
                res.Add(new List<int>() {nums[i], nums[j], diff});
                while(j +1 < nums.Length && nums[j] == nums[j+1])
                {
                    ++j;
                }
            }
            seen.Add(nums[j]);
        }
    }
    public IList<IList<int>> ThreeSum(int[] nums) {

        Array.Sort(nums);
        var res = new List<IList<int>>();

        for(int i = 0; i < nums.Length && nums[i]<= 0; ++i)
        {
            if(i == 0 || nums[i-1] != nums[i])
            {
                twoSum(nums, i, res);
            }
        }
        return res;

    }
}

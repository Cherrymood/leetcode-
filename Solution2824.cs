public class Solution2824 {
    public int CountPairs(IList<int> nums, int target) {
        
        int answer = 0;
        var nums1 = nums.ToArray();

        for (int i = 0; i < nums1.Length; i++)
        {
            for (int k = i+1; k < nums1.Length; k++)
            {
                if (nums1[i] + nums1[k] < target)
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}
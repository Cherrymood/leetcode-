public class Solution347 {
    public int[] TopKFrequent(int[] nums, int k) {
        
        if(nums.Length == 1) return nums;

        var dict = new Dictionary<int,int>();
        var ans = new int[k];

        foreach(var num in nums)
        {
            if(!dict.ContainsKey(num))
            {
                dict[num] = 1;
            }
            else
            {
                dict[num]++;
            }
        }
        foreach(var freq in dict.OrderByDescending(freq => freq.Value))
        {
            if(k == 0) break;

            ans[k-1] = freq.Key;
            k--;
        }


        return ans;
    }
}

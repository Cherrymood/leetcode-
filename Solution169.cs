public class Solution169 {
    public int MajorityElement(int[] nums) {
        
        var dict = new Dictionary<int, int> ();

        foreach (var num in nums)
        {
            if (!dict.ContainsKey(num))
            {
                dict[num] = 1;
            }
            else
            {
                dict[num]++;
            }
        }

        int length = nums.Length/2;

        foreach(var key in dict.Keys)
        {
            if (dict[key] > length)
            {
                return key;
            }
        }

        return 0;
    }
}

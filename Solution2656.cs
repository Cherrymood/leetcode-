public class Solution2656 {
    public int MaximizeSum(int[] nums, int k) {

        var maxsum = 0;
        var maxnum = nums.Max();
        maxsum += maxnum;

        for (int count = 1; count < k; count++)
        {
            maxsum += (maxnum + count);
        }

        return maxsum;
    }
}
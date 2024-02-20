public class Solution287 {
    public int FindDuplicate(int[] nums) {

        var hs = new HashSet<int>();
        var ans = 0;

        foreach(var num in nums)
        {
            if(hs.Contains(num))
            {
                ans = num;
                break;
            }
            hs.Add(num);
        }
        return ans;
    }
}

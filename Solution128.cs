public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        var hs = new HashSet<int>(nums);

        int ans = 0;

        foreach (var num in hs)
        {
            if (!hs.Contains(num-1))
            {
                int currNum = num;
                int currLength = 1;

                while(hs.Contains(currNum+1))
                {
                    currNum++;
                    currLength++;
                }

                ans = Math.Max( ans, currLength);
            }
            
        }
        return ans;
    }
}

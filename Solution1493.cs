public class Solution1493 {
    public int LongestSubarray(int[] nums) {

        int maxCount = 0;

        int zeroesCount = 0;
        int oncesCount = 0;
        int length = nums.Length;


        int right = 0;
        int left = 0;


        while (right < length)
        {
            if (nums[right] == 0)
            {
                zeroesCount ++;
            }
            else 
            {
                oncesCount ++;
            }

            if (zeroesCount > 1)
            {
                if (nums[left] == 0)
                {
                    zeroesCount --;
                }
                else 
                {
                    oncesCount --;
                }
                
                left ++;
            }
            maxCount = Math.Max(maxCount, right - left +1);

            right++;
           
        }
        return maxCount - 1;
    }
}
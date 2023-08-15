public class Solution1004 {
    public int LongestOnes(int[] nums, int k) {

        var count = 0;
        var maxCount = 0;
        var j = k;

        var right = 0;
        var left = 0;


        while (left < nums.Length)
        {
            if (nums[right] == 1)
            {
                count++;
                if (right == nums.Length -1)
                {
                    maxCount = Math.Max(count, maxCount);
                    break;
                }
                right++;
                continue;
            }

            if (nums[right] == 0 && j > 0)
            {
                count++;
                j--;
                
                if (right == nums.Length -1)
                {
                    maxCount = Math.Max(count, maxCount);
                    break;
                }
                right++;
                continue;
            }

            if (nums[right] == 0 && j == 0)
            {
                maxCount = Math.Max(count, maxCount);

                if (nums[left] == 1)
                {
                    count--;
                    left++;
                }
                if (nums[left] == 0)
                {
                    j++;
                    left++;
                    count--;
                }
            }

        }
        return maxCount;
        
    }
}
        
public class Solution1493 {
    public int LongestSubarray(int[] nums) {

        var deleteOneelement = 1;
        var countOnces = 0;
        var maxCount = 0;

        var left = 0;
        var right = 0;


        while (left < nums.Length)
        {
            if (nums[right] == 1)
            {
                countOnces++;

                if (right == nums.Length -1)
                {
                    maxCount = Math.Max(countOnces, maxCount);

                    break;
                }
                right++;
                continue;
            }
            if (nums[right] == 0 && deleteOneelement == 1)
            {
                if (right == nums.Length -1)
                {
                    maxCount = Math.Max(countOnces, maxCount);

                    break;
                }
                deleteOneelement--;
                right++;
                continue;
            }

            if (nums[right] == 0 && deleteOneelement == 0)
            {
                
                maxCount = Math.Max(countOnces, maxCount);

                if (right == nums.Length -1)
                {
                    maxCount = Math.Max(countOnces, maxCount);

                    break;
                }

                if (nums[left] == 1)
                {
                    countOnces--;
                    left++;
                    continue;
                }
                if (nums[left] == 0)
                {
                    deleteOneelement = 1;
                    left++;
                    continue;
                }
                
            }
        }
        if (!nums.Contains(1))
        {
            return 0;
        }
        
        
        if (deleteOneelement == 1)
        {
            return maxCount -1;
        }
       
        return maxCount;

    }


}
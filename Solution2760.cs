public class Solution2760 {
    public int LongestAlternatingSubarray(int[] nums, int threshold) {

        var counter = 0;
        var maxSub = 0;

        
        for (int i = 0; i < nums.Length; i++)
        {
            if ((nums[i] % 2 == 0) && (nums[i] <= threshold))
            {
                counter++;
                if (i+1 < nums.Length)
                {
                        if ((nums[i+1] % 2 != 0) && (nums[i+1] <= threshold) && (i+1 < nums.Length))
                        {
                            counter++;
                            i++;
                        }

                        else
                        {
                            maxSub = Math.Max(counter, maxSub);
                            counter = 0;
                        }
                }
            }
            else
                {
                    maxSub = Math.Max(counter, maxSub);
                    counter = 0;
                }

        }

        return Math.Max(counter, maxSub);

        
    }
}
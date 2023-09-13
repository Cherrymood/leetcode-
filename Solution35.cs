public class Solution35 {
    public int SearchInsert(int[] nums, int target) {

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                return i;
            }

            if (nums[i] > target)
            {
                return i;
            }
            if ( i == nums.Length-1 && nums[i] < target)
            {
                return i + 1;
            }
        }
        return 0;
    }
}
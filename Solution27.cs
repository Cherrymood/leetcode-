public class Solution27 {
    public int RemoveElement(int[] nums, int val) {

        int i = 0;

        foreach (int n in nums)
        {
            if (n != val)
            {
                nums[i] = n;
                i++;
            }
        }

        return i;
    }
}
public class Solution1822 {
    public int ArraySign(int[] nums) {

        int minus = 0;

        foreach(var num in nums)
        {
            if(num == 0)
            {
                return 0;
            }

            if(num < 0)
            {
                minus++;
            }
        }

        if(minus % 2 == 0)
        {
            return 1;
        }

        return -1;
    }
}
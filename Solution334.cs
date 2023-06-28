public class Solution334 {
    public bool IncreasingTriplet(int[] nums) {

        if (nums.Length >= 3)
        {
            var maxNum1 =int.MaxValue;
            var maxNum2 = int.MaxValue;

            foreach (int num in nums)
            {
                if (num > maxNum2)
                {
                    return true;
                }

                if (num < maxNum1)
                {
                    maxNum1 = num;
                }
                else if (num < maxNum2)
                {
                    maxNum2 = num;
                }
            }
        }

        return false;
    }
}
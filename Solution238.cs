public class Solution238 {
    public int[] ProductExceptSelf(int[] nums) {
        
        var arrAnswer = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            arrAnswer[i] = 1;
        }

        var leftprod = 1;
        var rightprod = 1;
        
        for (int i = 1, j = nums.Length - 2; i < nums.Length; ++i, --j)
        {
            leftprod *= nums[i - 1];
            rightprod *= nums[j + 1];
            
            arrAnswer[i] *= leftprod;
            arrAnswer[j] *= rightprod;
        }

        return arrAnswer;
    }
}
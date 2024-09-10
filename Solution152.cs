public class Solution {
    public int MaxProduct(int[] nums) {
        
        var prod = 1;
        var maxProd = nums[0];

        for(int i = 0; i < nums.Length; i++)
        {
            prod *= nums[i];

            if(prod >= maxProd)
            {
                maxProd = prod;
            }

            if(prod == 0)
            {
                prod = 1;
            }
        }

        prod = 1;

        for(int i = nums.Length-1; i >= 0; i--)
        {
            prod *= nums[i];
            if(prod > maxProd)
            {
                maxProd =prod;
            }
            if(prod == 0)
            {
                prod = 1;
            }
        }
        return maxProd;
    }
}

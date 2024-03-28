public class Solution122 {
    public int MaxProfit(int[] prices) {
        
        int min_Price = int.MaxValue;
        int ans = 0;

        for(int i = 0; i < prices.Length; i++)
        {
            if(prices[i] < min_Price)
            {
                min_Price = prices[i];
            }

            if(prices[i] > min_Price)
            {
                ans += prices[i] - min_Price;
                min_Price = prices[i];
            }

        }

        return ans;
    }
}

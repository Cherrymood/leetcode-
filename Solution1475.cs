public class Solution1475 {
    public int[] FinalPrices(int[] prices) {
        
        var answer = new int[prices.Length];

        for (int i = 0; i < prices.Length; i++)
        {
            var flag = false;

            for (int k = i+1; k < prices.Length; k++)
            {
                if (prices[k] <= prices[i])
                {
                    answer[i] = prices[i] - prices[k];
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                answer[i] = prices[i];
            }
        }
        return answer;
    }
}

public class Solution739 {
    public int[] DailyTemperatures(int[] temperatures) {
        
        var ans = new int[temperatures.Length];

        for(int i = 0; i < temperatures.Length; i++)
        {
            int days = 0;
            for(int j = i+1; j < temperatures.Length; j++)
            {
                days++;
                if(temperatures[j] > temperatures[i])
                {
                    ans[i] = days;
                    break;
                }
            }
        }
        return ans;
    }
}

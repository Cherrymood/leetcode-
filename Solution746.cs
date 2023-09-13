public class Solution746 {
    public int MinCostClimbingStairs(int[] cost) {
        
        int answer = 0;
        int start = 0;


        if (cost[1] < cost[0])
        {
            start = 1;
        }

        for (int i = start; i < cost.Length; i++)
        {
            if (i == cost.Length - 2 || i == cost.Length - 1)
            {
                answer += cost[i];
                break;
            }

            if (cost[i+1] < cost[i+2])
            {
                answer += cost[i+1];
            }
            if (cost[i+1] >= cost[i+2])
            {
                answer += cost[i+2];
                i++;
            }

        }

        return answer;
    }
}
public class Solution1351 {
    public int CountNegatives(int[][] grid) {
        
        int answer = 0;

        foreach (var gr in grid)
        {
            for (int i = 0; i < gr.Length; i++)
            {
                if (gr[i] < 0)
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}
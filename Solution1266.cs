public class Solution1266 {
    public int MinTimeToVisitAllPoints(int[][] points) {
        
        int answer = 0;

        for (int i = 0; i < points.Length - 1; i++)
        {
            answer += Math.Max(Math.Abs((points[i + 1][0] - points[i][0])), Math.Abs((points[i + 1][1] - points[i][1])));

        }

        return answer;

    }
}
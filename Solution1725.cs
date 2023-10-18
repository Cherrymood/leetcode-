public class Solution1725 {
    public int CountGoodRectangles(int[][] rectangles) {
        
        var rectangleLength = new int[rectangles.Length];

        for(int i = 0; i < rectangles.Length; i++)
        {
            rectangleLength[i] = Math.Min(rectangles[i][0],rectangles[i][1]);
        }

        Array.Sort(rectangleLength);

        int maxSq = rectangleLength[rectangles.Length - 1];

        int answer = 0;

        foreach (var num in rectangleLength)
        {
            if (num == maxSq)
            {
                answer++;
            }
        }

        return answer;
    }
}
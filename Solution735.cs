public class Solution735 {
    public int[] AsteroidCollision(int[] asteroids) {
        
        var stAst = new Stack<int>();

        foreach (var asteroid in asteroids)
        {
            if (asteroid > 0)
            {
                stAst.Push(asteroid);
            }
            else
            {
                while (stAst.Count > 0 && stAst.Peek() > 0 && stAst.Peek() < Math.Abs(asteroid))
                {
                    stAst.Pop();
                }
                if (stAst.Count == 0 || stAst.Peek() < 0)
                {
                    stAst.Push(asteroid);
                }
                else if (stAst.Peek() == Math.Abs(asteroid))
                {
                    stAst.Pop();
                }
            }

        }
        var answer = new int[stAst.Count];
        for (int i = stAst.Count - 1; i >= 0; i--)
        {
            answer[i] = stAst.Pop();
        }

        return answer;
    }
}
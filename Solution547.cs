public class Solution547 {

    public void Dfs(int i, int[][] isConnected, bool[] visit)
    {
        visit[i] = true;
        for(int j = 0; j < isConnected.Length; j++)
        {
            if(isConnected[i][j] == 1 && !visit[j])
            {
                Dfs(j, isConnected, visit);
            }
        }
    }
    public int FindCircleNum(int[][] isConnected) {
        var n = isConnected.Length;
        var visit = new bool[n];
        int numberOfComponents = 0;

        for(int i = 0; i < n; i++)
        {
           if(!visit[i])
           {
               numberOfComponents++;
               Dfs(i, isConnected, visit);
           }
        }

        return numberOfComponents;
    }
}
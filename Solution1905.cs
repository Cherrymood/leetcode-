public class Solution1905 {
    int n;
    int m;
    int ans = 0;
    HashSet<KeyValuePair<int, int>> vis2;
    bool is_Island = true;

    public void Dfs(int[][] grid1, int[][] grid2, int i, int k)
    {
        if(i < 0 || k < 0 || i >= m || k >= n || grid2[i][k] == 0 || vis2.Contains(new KeyValuePair<int, int>(i, k)))
        {
            return;
        }
        if(grid1[i][k] != grid2[i][k])
        {
            is_Island = false;
            return;
        }

        vis2.Add(new KeyValuePair<int, int> (i, k));

        Dfs(grid1, grid2, i+1, k);
        Dfs(grid1, grid2, i-1, k);
        Dfs(grid1, grid2, i, k+1);
        Dfs(grid1, grid2, i, k-1);
    }

    public int CountSubIslands(int[][] grid1, int[][] grid2) {
        m = grid1.Length;
        n = grid1[0].Length;
        vis2 = new HashSet<KeyValuePair<int, int>> ();

        for(int i = 0; i < m; i++)
        {
            for(int k = 0; k < n; k++)
            {
                if(grid2[i][k] == 1 && grid1[i][k] == 1 && !vis2.Contains(new KeyValuePair<int, int>(i, k)))
                {
                    Dfs(grid1, grid2, i, k);
                    if(is_Island == true)
                    {
                        ans++;
                    }
                    is_Island = true;
                }
            }
        }
        return ans;
    }
}

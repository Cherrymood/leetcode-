public class Solution1254 {
    int n;
    int m;
    int ans = 0;
    HashSet<KeyValuePair<int, int>> vis;
    bool is_Closed = true;

    public void Dfs(int[][] grid, int i, int k)
    {
        if (i < 0 || k < 0 || i >= n || k >= m)
        {
            is_Closed = false;
            return;
        }
        if (grid[i][k] == 1 || vis.Contains(new KeyValuePair<int, int>(i, k)))
        {
            return;
        }

        vis.Add(new KeyValuePair<int, int> (i, k));

        Dfs(grid, i+1, k);
        Dfs(grid, i-1, k);
        Dfs(grid, i, k-1);
        Dfs(grid, i, k+1);
    }

    public int ClosedIsland(int[][] grid) {
        
        n = grid.Length;
        m = grid[0].Length;
        vis = new HashSet<KeyValuePair<int, int>>();

        for(int i = 0; i < n; i++)
        {
            for(int k = 0; k < m; k++)
            {
                if(grid[i][k] == 0 && !vis.Contains(new KeyValuePair<int, int>(i, k)))
                {
                    Dfs(grid, i, k);
                    if(is_Closed == true)
                    {
                        ans++;
                    }
                    is_Closed = true;
                }
            }
        }
        return ans;
    }
}

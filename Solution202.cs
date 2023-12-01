public class Solution202 {

    int ans = 0;
    int n;
    int m;

    public void Dfs(char[][] grid, int i, int k)
    {
        if(i < 0 || i >= n || k < 0 || k >= m || grid[i][k] == '0')
        {
            return;
        }

        grid[i][k] = '0';
        
        Dfs(grid, i+1, k);
        Dfs(grid, i-1, k);
        Dfs(grid, i, k+1);
        Dfs(grid, i, k-1);
    }

    public int NumIslands(char[][] grid) {
        
        n = grid.Length;
        m = grid[0].Length;
        
        if (grid == null || n == 0) {
            return 0;
        }

        for(int i = 0; i < n; i++)
        {
            for (int k = 0; k < m; k++)
            {
                if (grid[i][k] == '1')
                {
                    ans++;
                    Dfs(grid, i, k);
                }
            }
        }
        return ans;
    }
}

public class Solution694 {
    int n;
    int m;
    HashSet<string> islands;
    HashSet<KeyValuePair<int, int>> vis;
    string earth;
    int ans = 0;

    public void Dfs(int[][] grid, int i, int k, int currI, int currK)
    {
        if( i < 0 || k < 0 || i >= n || k >= m || vis.Contains(new KeyValuePair<int, int>(i , k)) || grid[i][k] == 0)
        {
            return;
        }

        vis.Add(new KeyValuePair<int, int>(i , k));
        earth += Convert.ToString(currI) + Convert.ToString(currK);

        Dfs(grid, i+1, k, currI+1, currK);
        Dfs(grid, i-1, k, currI-1, currK);
        Dfs(grid, i, k+1, currI, currK+1);
        Dfs(grid, i, k-1, currI, currK-1);
    }
    
    public int NumDistinctIslands(int[][] grid) {

        islands = new HashSet<string>();
        vis = new HashSet<KeyValuePair<int, int>>();
        earth = "";
        n = grid.Length;
        m = grid[0].Length;

        for(int i = 0; i < n; i++)
        {
            for(int k = 0; k < m; k++)
            {
                if(grid[i][k] == 1 && !vis.Contains(new KeyValuePair<int, int>(i , k)))
                {
                    Dfs(grid, i, k , '0', '0');

                    if (!islands.Contains(earth))
                    {
                        islands.Add(earth);
                        ans++;
                    }
                    earth = "";
                }
            }
        }
        return ans;
    }
}

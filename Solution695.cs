public class Solution {
    int maxArea = 0;
    HashSet<KeyValuePair<int, int>> visited;
    int area = 0;
    int n;
    int m;

    public void Dfs(int[][] grid, int i, int k)
    {
        if(i >= 0 && k >= 0 && i < n && k < m && grid[i][k] == 1 && !visited.Contains(new KeyValuePair<int, int>(i , k)))
        {
            area++;
            visited.Add(new KeyValuePair<int, int>(i , k));
            Dfs(grid, i+1, k);
            Dfs(grid, i-1, k);
            Dfs(grid, i, k+1);
            Dfs(grid, i, k-1);
        }
    }
    public int MaxAreaOfIsland(int[][] grid) {
        n = grid.Length;
        m = grid[0].Length;
        visited = new HashSet<KeyValuePair<int, int>>();

        for(int i = 0; i < n; i++)
        {
            for(int k = 0; k < m; k++)
            {
                if(grid[i][k] == 1 && !visited.Contains(new KeyValuePair<int, int>(i, k)))
                {
                    Dfs(grid, i, k);
                    maxArea = Math.Max(maxArea, area);
                    area = 0;
                }
            }
        }
        return maxArea;
    }
}

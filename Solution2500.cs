public class Solution2500 {
    public int DeleteGreatestValue(int[][] grid) {

        foreach (int[] row in grid)
        {
            Array.Sort(row);
        }

        int res = 0;

        for (int i = grid[0].Length - 1; i >= 0; i--)
        {
            int tmp = 0;
            for (int j = 0; j < grid.Length; j++)
                tmp = Math.Max(tmp, grid[j][i]);
            res += tmp;
        }
        return res;
    }
}
public class Solution2352 {
    public int EqualPairs(int[][] grid) {

        var gridDict = new Dictionary <string, int> ();
        var colDict = new Dictionary <string, int> ();
        var key = "";
        var indexRaw = 0;
        var indexColomn = 0;
        var answer = 0;


        while (indexRaw < grid.Length)
        {
            if (indexColomn < grid[0].Length)
            {
                key += grid[indexRaw][indexColomn] + " ";
                indexColomn++;
            }
            else
            {
                if (!gridDict.ContainsKey(key))
                {
                    gridDict[key] = 1;
                }
                else
                {
                    gridDict[key]++;
                }

                key = "";
                indexColomn = 0;
                indexRaw++;
            }
        }

        indexColomn = 0;
        indexRaw = 0;

        while (indexColomn < grid[0].Length)
        {
                if (indexRaw < grid.Length)
                {
                    key += grid[indexRaw][indexColomn] + " ";
                    indexRaw++;
                }
                else
                {
                    if (!colDict.ContainsKey(key))
                {
                    colDict[key] = 1;
                }
                else
                {
                    colDict[key]++;
                }

                    key = "";
                    indexRaw = 0;
                    indexColomn++;
                }
        }
        
        foreach (var k in gridDict.Keys)
        {
            if (colDict.ContainsKey(k))
            {
                answer += gridDict[k] * colDict[k];
            }
        }

        return answer;
    }
}
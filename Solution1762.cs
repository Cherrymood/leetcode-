public class Solution1762 {
    public int[] FindBuildings(int[] heights) {
        
        var ans = new List<int>();
        var stack = new Stack<int>(heights);
        var length = heights.Length-1;
        var min = 0;

        while(stack.Count > 0)
        {
            var hPop = stack.Pop();
            
            if (hPop > min)
            {
                min = hPop;
                ans.Add(length);
            }

            length--;
        }

        var res = ans.ToArray();
        Array.Sort(res);

        return res;

    }
}

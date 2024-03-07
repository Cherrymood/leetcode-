public class Solution1337 {
    public int[] KWeakestRows(int[][] mat, int k) {

        var ans = new int[k];
        int ind = 0;

        var dict = new Dictionary<int, int>();
        
        for(int i = 0; i < mat.Length; i++)
        {
            dict[i] = mat[i].Sum();
        }

        var dict1 = from entry in dict orderby entry.Value ascending select entry;

        foreach(var kvp in dict1)
        {
            ans[ind] = kvp.Key;
            ind++;

            if(ind == k)
            {
                break;
            }
        }

        return ans;
    }
}

public class Solution1207 {
    public bool UniqueOccurrences(int[] arr) {
        
        var pairs = new  Dictionary<int, int> ();
        var set = new HashSet<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (!pairs.ContainsKey(arr[i]))
            {
                pairs.Add(arr[i], 1);
            }

            else
            {
                pairs[arr[i]]++;
            }
        }

        foreach (var val in pairs.Values)
        {
            set.Add(val);
        }

        if (set.Count == pairs.Values.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
  
}
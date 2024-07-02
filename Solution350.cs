using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        var dict1 = new Dictionary<int, int>();
        var dict2 = new Dictionary<int, int>();
        
        foreach (var num in nums1) {
            if (dict1.ContainsKey(num)) {
                dict1[num]++;
            } else {
                dict1[num] = 1;
            }
        }
        
        foreach (var num in nums2) {
            if (dict2.ContainsKey(num)) {
                dict2[num]++;
            } else {
                dict2[num] = 1;
            }
        }
        
        var result = new List<int>();
        
        foreach (var kvp in dict1) {
            if (dict2.ContainsKey(kvp.Key)) {
                int count = Math.Min(kvp.Value, dict2[kvp.Key]);
                for (int i = 0; i < count; i++) {
                    result.Add(kvp.Key);
                }
            }
        }
        
        return result.ToArray();
    }
}

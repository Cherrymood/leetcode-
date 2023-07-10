public class Solution1732 {
    public int LargestAltitude(int[] gain) {

        int a = 0;
        int max = 0;

        for (int i = 0; i < gain.Length; i++)
        {
            a += gain[i];
            max = Math.Max(a, max);
        }
        return max;

        
    }
}
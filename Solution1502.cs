public class Solution1502
 {
    public bool CanMakeArithmeticProgression(int[] arr) {
        
        if(arr.Length == 2)
        {
            return true;
        }

        Array.Sort(arr);

        int diff = arr[0] - arr[1];

        for(int i = 1; i < arr.Length - 1; i++)
        {
            if(diff != arr[i] - arr[i+1])
            {
                return false;
            }
        }
        return true;
    }
}
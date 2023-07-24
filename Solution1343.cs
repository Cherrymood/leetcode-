public class Solution1343 {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {

        var counter = 0;
        var lengtharr = arr.Length - k;
        var sum = 0;
        
        for (int i = 0; i < k; i++)
        {
            sum += arr[i];
        }

        var avgSum = sum/k;

        if (avgSum >= threshold)
            {
                counter++;
            }

        for (int i = 0, j = k; i < lengtharr; i++, j++)
        {
            sum -= arr[i];
            sum += arr[j];

            avgSum = sum/k;

            if (avgSum >= threshold)
            {
                counter++;
            }
        }
        return counter; 
    }
}
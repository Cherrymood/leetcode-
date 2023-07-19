public class Solution219 {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        
        if (k == 0)
        {
            return false;
        }
        var queueNEW = new Queue<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (queueNEW.Contains(nums[i]))
            {
                return true;
            }

            else
            {
                if (queueNEW.Count > k)
                {
                    queueNEW.Dequeue();
                }
                    queueNEW.Enqueue(nums[i]);

            }
        }
        return false;
    }
}
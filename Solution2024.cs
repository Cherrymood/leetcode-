public class Solution2024 {
    public int MaxConsecutiveAnswers(string answerKey, int k) {
        
        int length = answerKey.Length;
        int maxCount = 0;
        int tCount = 0;
        int fCount = 0;

        int right = 0;
        int left = 0;

        while (right < length)
        {
            if (answerKey[right] == 'T')
            {
                tCount++;
            }
            else
            {
                fCount++;
            }

            if (Math.Min(tCount, fCount) > k)
            {
                if (answerKey[left] == 'T')
                {
                    tCount--;
                }
                else 
                {
                    fCount--;
                }
                left++;
            }
            maxCount = Math.Max(maxCount, right - left + 1);
            
            right++;
        }

        return maxCount;

    }
}
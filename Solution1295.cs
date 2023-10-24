public class Solution1295 {
    public int FindNumbers(int[] nums) {
        
        int answer = 0;

        foreach (var num in nums)
        {
            var strNum = "";
            strNum += num;

            if (strNum.Length % 2 == 0)
            {
                answer++;
            }

        }

        return answer;
    }
}
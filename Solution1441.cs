public class Solution1441 {
    public IList<string> BuildArray(int[] target, int n) {
        
        var answer = new List<string>();
        var i = 0;

        for (int num = 1; num <= n && i < target.Length; num++)
        {
            if (num == target[i])
            {
                answer.Add("Push");
                i++;
            }
            else if (num != target[i])
            {
                answer.Add("Push");
                answer.Add("Pop");
            }
        }
        return answer;
    }
}
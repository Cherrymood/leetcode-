public class Solution1342 {
    public int NumberOfSteps(int num) {

        int answer = 0;              

        while (num !=0)
        {
            if (num % 2 == 0)
            {
                num /= 2;
                answer += 1;
            }
            else
            {
                num -=1;
                answer +=1;
            }
        }
        return answer;
    
    }
}
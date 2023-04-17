public class Solution771 {
    public int NumJewelsInStones(string jewels, string stones) {
        int answer = 0;

        foreach (char jewel in jewels)
        {
            foreach (char stone in stones)
            {
                if (jewel == stone)
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}
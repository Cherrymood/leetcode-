public class Solution74 {
    public bool SearchMatrix(int[][] matrix, int target) {
        
        var answer = false;
        var indexRaw = -1;

        for (int i = 0; i < matrix.Length; i++)
        {
            if (target >= matrix[i][0] && target <= matrix[i][^1])
            {
                indexRaw = i;
            }
        }
        
        if (indexRaw == -1)
        {
            return answer;
        }


        foreach (var value in matrix[indexRaw])
        {
            if (value == target)
            {
                answer = true;
                return answer;
            }

            if (value > target)
            {
                return answer;
            }
        }




        return answer;
    }
}
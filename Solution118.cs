public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        
        var pascalTriangle = new List<List<int>>(){{1}};

        if (numRows == 1)
        {
            return pascalTriangle;
        }

        if (numRows == 2)
        {
            return pascalTriangle.Add(new List<int>(){1});
        }


    }
}
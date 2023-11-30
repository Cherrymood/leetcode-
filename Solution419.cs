public class Solution {
    
    int ans = 0;

    public void Dfs(char[][] board, int i, int k)
    {
        if(i == 0 || board[i - 1][k] == '.')
        {
            if (k == 0 || board[i][k - 1] == '.')
            {
                ans++;
            }
        }
    }

    public int CountBattleships(char[][] board) {
    
        for (int i = 0; i < board.Length; i++)
        {
            for (int k = 0; k < board[0].Length; k++)
            {
                if (board[i][k] == 'X')
                {
                    Dfs(board, i,k);
                }
            }
        }
        return ans;
    }
}

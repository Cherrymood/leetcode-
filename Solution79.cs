public class Solution {
    private bool Helper(char[][] board, string word, int i, int j, int k)
    {
        if (k == word.Length)
        {
            return true; // All characters matched
        }

        if (i < 0 || j < 0 || i >= board.Length || j >= board[0].Length || board[i][j] != word[k])
        {
            return false; // Out of bounds or character does not match
        }

        // Mark the cell as visited by modifying it temporarily
        char temp = board[i][j];
        board[i][j] = '#';

        // Check all four directions
        bool found = Helper(board, word, i + 1, j, k + 1) ||
                     Helper(board, word, i - 1, j, k + 1) ||
                     Helper(board, word, i, j + 1, k + 1) ||
                     Helper(board, word, i, j - 1, k + 1);

        // Restore the cell's original value
        board[i][j] = temp;

        return found;
    }

    public bool Exist(char[][] board, string word) {
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == word[0] && Helper(board, word, i, j, 0))
                {
                    return true;
                }
            }
        }
        return false;
    }
}

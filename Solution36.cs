public class Solution36 {
    public bool IsValidSudoku(char[][] board) {
        var row = new Dictionary<int, HashSet<char>>();
        var col = new Dictionary<int, HashSet<char>>();
        var block = new Dictionary<KeyValuePair<int, int>, HashSet<char>>();

        for(int r = 0; r < board.Length; r++)
        {
            for(int c = 0; c < board.Length; c++)
            {
                if(!row.ContainsKey(r))
                {
                    row[r] = new HashSet<char>();
                }
                if(!col.ContainsKey(c))
                {
                    col[c] = new HashSet<char>();
                }
                var blockkey = new KeyValuePair<int, int>(r / 3, c /3);
                if(!block.ContainsKey(blockkey))
                {
                    block[blockkey] = new HashSet<char>();
                }

                if(board[r][c] != '.' && 
                   (!row[r].Add(board[r][c]) ||
                   !col[c].Add(board[r][c]) ||
                   !block[blockkey].Add(board[r][c])))
                   {
                    return false;
                   }
            }
        }

        return true;

    }
}

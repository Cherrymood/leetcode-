public class Solution657 {
    public bool JudgeCircle(string moves) {
        
        int x = 0;
        int y = 0;

        for(int i = 0; i < moves.Length; i++)
        {
            if(moves[i] == 'U')
            {
                y++;
            }
            if(moves[i] == 'D')
            {
                y--;
            }
            if(moves[i] == 'L')
            {
                x++;
            }
            if(moves[i] == 'R')
            {
                x--;
            }
        }

        return x == 0 && y == 0;
    }
}
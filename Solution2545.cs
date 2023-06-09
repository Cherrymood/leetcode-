public class Solution2545 {
    public int[][] SortTheStudents(int[][] score, int k) {
            
            
            Array.Sort(score, (a,b) => {
                
            return b[k].CompareTo(a[k]);
            });

            return score;   
        
    }
}
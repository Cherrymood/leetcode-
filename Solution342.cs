public class Solution342 {

    public bool IsPowerOfFour(int n) {
        
        if(n == 1) return true;
        if(n % 4 != 0) return false;
        if(n < 1) return false;

        return IsPowerOfFour(n/4);
    }
}

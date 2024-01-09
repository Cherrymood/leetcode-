public class Solution58 {
    public int LengthOfLastWord(string s) {
        
        s = s.Trim();
        var strArr = s.Split(" ");

        return strArr[strArr.Length-1].Length;
    }
}
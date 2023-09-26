public class Solution28 {
    public int StrStr(string haystack, string needle) {
     
     if (haystack.Length < needle.Length)
        {
            return -1;
        }
        else
        {
            return haystack.IndexOf(needle);
        }
    }
}
public class Solution443 {
    public int Compress(char[] chars) {

       var i = 0;
       var j = 0;
       
       while (i < chars.Length)
       {
            var current = chars[i];
            var count = 0;

            while(i < chars.Length && chars[i] == current)
            {
                i++;
                count++;
            }
            chars[j++] = current;

            if (count > 1)
            {
                foreach (var counterChar in count.ToString())
                {
                    chars[j++] = counterChar;
                }
            }
        }

        return j;
    }
}
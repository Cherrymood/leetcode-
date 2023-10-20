public class Solution942 {
    public int[] DiStringMatch(string s) {
        
        var arr = new int[s.Length+1];

        for (int i = 0; i <= s.Length; i++)
        {
            arr[i] = i;
        }

        var arrAns = new int[s.Length+1];
        var index1 = 0;
        var index2 = arr.Length-1;

        for (int i = 0; i < s.Length; i++)

        {
            if (s[i] == 'I')
            {
                arrAns[i] = arr[index1];
                arr[index1] = 0;
                index1++;
            }

            if (s[i] == 'D')
            {
                arrAns[i] = arr[index2];
                arr[index2] = 0;
                index2--;
            }
        }
        Array.Sort(arr);

        arrAns[arrAns.Length - 1]  = arr[arr.Length-1];

        return arrAns;

    }
}
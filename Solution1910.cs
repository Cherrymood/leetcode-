public class Solution {
    public int[] NextLargerNodes(ListNode head) {
        var listNums = new List<int>();

        while(head != null)
        {
            listNums.Add(head.val);
            head = head.next;
        }

        var listNums1 = listNums.ToArray();
        var ans = new int[listNums1.Length];

        for(int i = 0; i < listNums1.Length; i++)
        {
            for(var k = i+1; k < listNums1.Length; k++)
            {
                if (listNums1[i] < listNums1[k])
                {
                    ans[i] = listNums1[k];
                    break;
                }
            }

        }
        return ans;

    }
}
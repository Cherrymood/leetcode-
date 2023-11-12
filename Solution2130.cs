public class Solution2130 {
    public int ListLength(ListNode head)
    {
        var pointer = head;
        var length = 0;

        while(pointer != null)
        {
            length++;
            pointer = pointer.next;
        }
        return length;
    }
    public int PairSum(ListNode head) {
        
        var length = ListLength(head);
        var arrNums = new int[length];
        int index = 0;

        while (head != null)
        {
            arrNums[index] = head.val;
            index++;
            head = head.next;
        }

        int answer = 0;

        for (int i = 0, k = arrNums.Length-1; i < k; i++, k--)
        {
            var sum = arrNums[i] + arrNums[k];
            answer = Math.Max(answer, sum);
        }

        return answer;

    }
}
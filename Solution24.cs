public class Solution24 {
    public ListNode SwapPairs(ListNode head) {
        
        if (head == null || head.next == null)
        {
            return head;
        }
        
        ListNode slow = head;
        ListNode fast = slow.next;
        int index = 0;

        while(fast != null)
        {
            if (index == 2 || index == 0)
            {
                (slow.val, fast.val) = (fast.val, slow.val);
                index = 0;
            }

            index++;
            slow = slow.next;
            fast = fast.next;
        }

        return head;
    }
}
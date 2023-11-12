public class Solution203 {
    public ListNode RemoveElements(ListNode head, int val) {
        
        if (head == null)
        {
            return head;
        }
        
        
        ListNode slow = head;
        ListNode fast = head.next;

        while(fast != null)
        {
            if (fast.val == val)
            {
                fast = fast.next;
                slow.next = fast;
                continue;
            }

            slow = slow.next;
            fast = fast.next;
        }

        if (head.val == val)
        {
            return head.next;
        }

        return head;

    }
}
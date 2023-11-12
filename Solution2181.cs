public class Solution2181 {
    public ListNode MergeNodes(ListNode head) {
        if (head == null)
        {
            return head;
        }
        ListNode slow = head;
        ListNode fast = head.next;

        while(fast != null)
        {
            if (fast.val == 0 && fast.next != null) 
            {
                slow.next = fast;
                slow = fast;
                fast = fast.next;
                continue;
            }
            if (fast.val == 0 && fast.next == null) 
            {
                slow.next = null;
                break;
            }

            slow.val += fast.val;
            fast = fast.next;
        }

        return head;
        
    }
}
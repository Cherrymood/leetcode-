public class Solution2095 {
    public ListNode DeleteMiddle(ListNode head) {
        if (head == null) return  null;
        if(head.next == null) return null;

        ListNode prev = null;
        var slow = head;
        var fast = head;

        while(fast != null && fast.next != null)
        {
            fast = fast.next.next;
            prev = slow;
            slow = slow.next;
        }

        prev.next = slow.next;

        return head;

    }
}

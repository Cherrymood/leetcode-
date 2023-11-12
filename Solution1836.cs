public class Solution1836 {
    public List<int> Duplicates(ListNode head)
    {
        var hs = new HashSet<int>();
        var liVals = new List<int>();
        var pointer = head;

        while(pointer != null)
        {
            if (hs.Contains(pointer.val))
            {
                liVals.Add(pointer.val);
                pointer = pointer.next;
            }
            else
            {
                hs.Add(pointer.val);
                pointer = pointer.next;
            }
        }
        return liVals;
    }
    public ListNode DeleteDuplicatesUnsorted(ListNode head) {
    
        ListNode slow = head;
        ListNode fast = head.next;

        var lookUp = Duplicates(head);

        while (fast != null)
        {
            if(lookUp.Contains(fast.val))
            {
                fast = fast.next;
                slow.next = fast;
                continue;
            }

            fast = fast.next;
            slow = slow.next;
        }

        if (lookUp.Contains(head.val))
        {
            return head.next;
        }
        return head;

    }
}
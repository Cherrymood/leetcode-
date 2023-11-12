public class Solution1721 {
    public int Length(ListNode head)
    {
        int length = 0;
        var pointer = head;

        while(pointer != null)
        {
            length++;
            pointer = pointer.next;
        }
        return length;
    }
    public ListNode SwapNodes(ListNode head, int k) {
        
        var length = Length(head);

        if (length == 2 && k == 2)
        {
            (head.val, head.next.val) = (head.next.val, head.val);
            return head;
        }

        int index1 = 0;
        var pointer = head;

        while(pointer != null)
        {
            index1++;
            if (index1 == k)
            {
                break;
            }
            pointer = pointer.next;
        }

        var pointer1 = head;
        int index2 = 0;

        while(pointer1 != null)
        {
            index2++;

            if (index2 == length - k +1)
            {
                break;
            }
            pointer1 = pointer1.next;
        }

        (pointer.val, pointer1.val) = (pointer1.val, pointer.val);

        return head;


    }
}
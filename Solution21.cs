public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
 }

public class Solution21 {

    public ListNode MergeTwoLists21(ListNode l1, ListNode l2) {

        if (l1 == null || l2 == null)
        {
            return l1 ?? l2;
        }

        if (l1.val <= l2.val)
        {
            l1.next = MergeTwoLists21(l1.next,l2);
            return l1;
        }
        else
        {
            l2.next = MergeTwoLists21(l1,l2.next);
            return l2;
        }
    }
}
public class Solution1265 {
    public void PrintLinkedListInReverse(ImmutableListNode head) {
        if (head != null)
        {
            PrintLinkedListInReverse(head.GetNext());
            head.PrintValue();
        }
    }
}
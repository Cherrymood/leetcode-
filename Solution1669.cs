ublic class Solution1669 {
    public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2) {
        
        ListNode slow = list1;
        ListNode fast = list1.next;
        ListNode pointer2 = list2;

        int slowIndex = 0;
        int fastIndex = 1;

        while (slowIndex != a-1)
        {
            slowIndex++;
            slow = slow.next;
        }

        while (fastIndex != b+1)
        {
            fastIndex++;
            fast = fast.next;
        }

        while (pointer2.next != null)
        {
            pointer2 = pointer2.next;
        }

        slow.next = list2;
        pointer2.next = fast;

        return list1;
    }
}
namespace Algorithms_CS.Problems
{
    // You are given the head of a singly linked-list. The list can be represented as:
    // L0 → L1 → … → Ln-1 → Ln
    // Reorder the list to be on the following form:
    // L0 → Ln → L1 → Ln-1 → L2 → Ln-2 → …
    // You may not modify the values in the list's nodes. Only nodes themselves may be changed.
    //
    // Example 1:
    // Input: head = [1,2,3,4]
    // Output: [1,4,2,3]
    //
    // Example 2:
    // Input: head = [1,2,3,4,5]
    // Output: [1,5,2,4,3]
    public class ReorderList1
    {
        public void ReorderList(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            ListNode tail = slow.next;
            slow.next = null;

            ListNode prev = null;
            ListNode current = tail;
            while(current != null)
            {
                ListNode temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            tail = prev;

            while(tail != null)
            {
                ListNode tempHead = head.next;
                ListNode tempTail = tail.next;

                head.next = tail;
                head.next.next = tempHead;
                tail = tempTail;
                head = tempHead;
            }
        }
    }
}

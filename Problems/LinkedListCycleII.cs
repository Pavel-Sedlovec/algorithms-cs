namespace Algorithms_CS.Problems
{
    // Given the head of a linked list, return the node where the cycle begins.
    // If there is no cycle, return null.
    // There is a cycle if some node can be reached again by continuously following the next pointer.
    // Do not modify the linked list.
    //
    // Example 1:
    // Input: head = [3,2,0,-4], pos = 1
    // Output: tail connects to node index 1
    // Explanation: There is a cycle, tail connects to the second node.
    //
    // Example 2:
    // Input: head = [1,2], pos = 0
    // Output: tail connects to node index 0
    // Explanation: There is a cycle, tail connects to the first node.
    //
    // Example 3:
    // Input: head = [1], pos = -1
    // Output: no cycle
    // Explanation: There is no cycle in the linked list.
    //
    // Follow up: Can you solve it using O(1) (i.e. constant) memory?
    public class LinkedListCycleII
    {
        // O(n) memory
        public ListNode DetectCycle(ListNode head)
        {
            HashSet<ListNode> set = new HashSet<ListNode>();
            while (head != null)
            {
                set.Add(head);
                if (set.Contains(head.next)) return head.next;
                head = head.next;
            }
            return null;
        }


        // O(1) memory
        public ListNode DetectCycleOptimize(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if(fast == slow)
                {
                    slow = head;
                    while(slow != fast)
                    {
                        slow = slow.next;
                        fast = fast.next;
                    }
                    return slow;
                }
            }
            return null;
        }
    }
}

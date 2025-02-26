/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        if(left == right) return head;

        ListNode dummyHead = new ListNode(0, head);
        ListNode prevLeft = dummyHead;

        for(int i = 1; i < left; i++){
            prevLeft = prevLeft.next;
        }

        ListNode prev = null;
        ListNode current = prevLeft.next;
        ListNode tail = current;

        for(int i = left; i <= right; i++){
            ListNode next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        prevLeft.next = prev;
        tail.next = current;

        return dummyHead.next;
    }
}

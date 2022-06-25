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
    public ListNode DeleteDuplicates(ListNode head) {
        if (head == null || head.next == null) return head;
        
        var pointer = head;
        while (pointer.next != null)
        {
            if(pointer.val == pointer.next.val)
            {
                pointer.next = pointer.next.next;
            }
            else{
                pointer = pointer.next;
            }
        }
        return head;
    }
}
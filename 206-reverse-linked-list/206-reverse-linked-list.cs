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
    public ListNode ReverseList(ListNode head) {
        if(head == null)   return head;
        
        ListNode CurrentNode = head;
        ListNode PrevNode = null;
        
        while(CurrentNode != null)
        {
            ListNode TempNode = CurrentNode.next;
            CurrentNode.next = PrevNode;
            PrevNode = CurrentNode;
            CurrentNode = TempNode;
        }
        return PrevNode;
    }
}
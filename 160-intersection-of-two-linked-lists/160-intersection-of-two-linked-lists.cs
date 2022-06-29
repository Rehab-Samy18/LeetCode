/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        ListNode p1 = headA, p2 = headB;
        // loop either stop at the intersect or at the end of two lists
        while(p1 != p2){
            // move pointer to list B at the end of list A
            if(p1 == null) p1 = headB;
            else p1 = p1.next;
            
            // move pointer to list A at the end of list B
            if(p2 == null) p2 = headA;
            else p2 = p2.next;
        }
        return p1;
    }
}
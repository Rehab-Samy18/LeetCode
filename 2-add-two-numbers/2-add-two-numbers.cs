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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode head = new ListNode();
        var pointer = head;
        int i = 0;
        while(l1!=null||l2!=null)
        {
            i = (l1==null?0:l1.val)+(l2==null?0:l2.val)+i;
            pointer.next = new ListNode(i%10);
            pointer = pointer.next;
            i = i / 10;
            
            l1 = l1?.next;
            l2 = l2?.next;
        }
        if(i!=0){
                pointer.next = new ListNode(i);
            }
        return head.next;
    }
}
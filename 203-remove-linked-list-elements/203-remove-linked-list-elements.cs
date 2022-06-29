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
    public ListNode RemoveElements(ListNode head, int val) {
        ListNode merged = null;
        ListNode pointer = merged;
        while(head!=null)
        {
            if(head.val != val)
            {
                ListNode newNode = new ListNode(head.val);
                if(merged == null)  merged = newNode;
                else {
                    pointer.next = newNode;
                }
                pointer = newNode;
            }
            head = head.next;
        }
        return merged;
    }
}
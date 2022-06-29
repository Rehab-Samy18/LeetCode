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
    public int GetDecimalValue(ListNode head) {
        ListNode pointer = head;
        int result = 0;
        int count = 0;
        while(pointer != null)
        {
            count++;
            pointer = pointer.next;
        }
        count--;
        pointer = head;
        while(pointer!=null)
        {
            if(pointer.val==1)
            {
                result += Convert.ToInt32(Math.Pow(2,count));
            }
            count--;
            pointer = pointer.next;
        }
        return result;
    }
}
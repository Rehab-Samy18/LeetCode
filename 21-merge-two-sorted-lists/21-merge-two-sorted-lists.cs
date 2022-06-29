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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode merged = null;
        var pointer = merged;
        while(list1 != null && list2 != null)
        {
            if(list1.val <= list2.val)
            {
                ListNode newNode = new ListNode(list1.val);
                if(merged==null)
                {
                    merged = newNode;
                }
                else
                {
                    pointer.next = newNode;
                }
                pointer = newNode;
                list1 = list1.next;
            }
            else{
                ListNode newNode = new ListNode(list2.val);
                if(merged==null)
                {
                    merged = newNode;
                }
                else
                {
                    pointer.next = newNode;
                }
                pointer = newNode;
                list2 = list2.next;
            }
        }
        if(list1 != null) {
            if (merged == null)
                merged = list1;
            else
                pointer.next = list1;
        }
        if(list2 != null) {
            if (merged == null)
                merged = list2;
            else
                pointer.next = list2;
        }
        return merged;
    }
}
public class Solution {
    public int Search(int[] nums, int target) {
        return nums.Contains(target)?Array.IndexOf(nums,target):-1;
    }
}
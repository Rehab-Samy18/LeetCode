public class Solution {
    public int[] BuildArray(int[] nums) {
        int[] ans;
        ans = new int[nums.Length];
        foreach(int i in nums){
            ans[i] = nums[nums[i]];
        }
        return ans;
    }
}
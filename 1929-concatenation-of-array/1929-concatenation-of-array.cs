public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length;
        int[] ans;
        ans = new int[n*2];
        for(int i=0;i<nums.Length;i++){
            Console.WriteLine(nums[i]);
            ans[i] = nums[i];
            ans[i + n] = nums[i];
        }
        return ans;
    }
}
public class Solution {
    public int[] RunningSum(int[] nums) {
        int[] sum;
        sum = new int[nums.Length];
        sum[0] = nums[0];
        for(int i=1;i<nums.Length;i++){
           sum[i] = sum[i-1] + nums[i]; 
        }
        return sum;
    }
}
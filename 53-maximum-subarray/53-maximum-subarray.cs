public class Solution {
    public int MaxSubArray(int[] nums) {
        int max = int.MinValue;
        int sum = 0;
        foreach(var i in nums)
        {
            sum += i;
            if(sum > max)
            {
                max = sum;
            }
            if(sum<0)
            {
                sum = 0;
            }
        }
        return max;
    }
}
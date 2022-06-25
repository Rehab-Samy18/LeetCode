public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums==null||nums.Length==0)
        {
            return 0;
        }
        int count = 1;
        int curIndex = 0;
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i]!=nums[curIndex])
            {
                nums[++curIndex]=nums[i];
                count = 0;
            }
            else if(count<2){
                nums[++curIndex]=nums[i];
            }
            count++;
        }
        return curIndex+1;
    }
}
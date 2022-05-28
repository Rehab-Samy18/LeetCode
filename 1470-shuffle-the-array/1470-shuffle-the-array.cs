public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] arr1;
        arr1 = new int[n];
        int[] arr2;
        arr2 = new int[n];
        int[] result;
        result = new int[n*2];
        int j = 0;
        int z =0;
        for(int i = 0;i < n; i++){
            arr1[i] = nums[i];
        }
        for(int i = n;i < n*2; i++){
            arr2[j] = nums[i];
            j++;
        }
        for(int i = 0;i < result.Length; i+=2){
            
            result[i] = arr1[z];
            result[i+1]=arr2[z];
            z++;
        }
        return result;
    }
}
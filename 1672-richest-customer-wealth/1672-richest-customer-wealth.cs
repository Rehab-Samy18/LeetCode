public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int[] CusWealth;
        int max = 0,min=0;
        CusWealth = new int[accounts.Length];
        for(int i = 0;i < accounts.Length; i++){
            CusWealth[i] = 0;
            for(int j = 0;j < accounts[i].Length; j++){
                CusWealth[i] += accounts[i][j];
            }
        }
        for(int z = 0;z<CusWealth.Length;z++){
            //max = CusWealth[z-1];
           if(CusWealth[z]>max){
               max = CusWealth[z];
           }
            else{
                max = max;
            }
        }
        return max;
    }
    
}
public class Solution {
    public int MostWordsFound(string[] sentences) {
        int[] count;
        count = new int[sentences.Length];
        int max = 0;
        for(int i=0;i<sentences.Length;i++){
            count[i] = sentences[i].Split(' ').ToList().Count;
        }
        for(int i=0;i<count.Length;i++){
            if(count[i]>max){
                max = count[i];
            }
        }
        return max;
    }
}
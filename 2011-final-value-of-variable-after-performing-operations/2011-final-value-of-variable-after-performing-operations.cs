public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int X = 0;
        foreach(string i in operations){
            switch(i){
                case "++X":
                    X++;
                    break;
                case "X++":
                    X++;
                    break;
                case "--X":
                    X--;
                    break;
                case "X--":
                    X--;
                    break;
            }
        }
        return X;
    }
}
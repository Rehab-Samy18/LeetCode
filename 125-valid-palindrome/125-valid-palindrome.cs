public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder sb = new StringBuilder();
        foreach(char c in s.ToCharArray())
        {
            if(char.IsLetterOrDigit(c))
            {
                sb.Append(c);
            }
        }
        string str = sb.ToString().ToLower();
        for(int i=0;i<str.Length/2;i++)
        {
            if(str[i]!=str[str.Length-1-i]){
                return false;
            }
        }
        return true;
    }
}
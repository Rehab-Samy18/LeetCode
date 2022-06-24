public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0)  return false;
        string s = x.ToString();
        for(int i = 0;i < s.Length;i++)
        {
            if(s[i]!=s[s.Length-1-i])
            {
                return false;
            }
        }
        return true;
    }
}
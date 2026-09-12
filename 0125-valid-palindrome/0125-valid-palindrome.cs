public class Solution {

    public static string modifyString(string s){
        s = s.ToLower();
        string newStr = "";
        foreach(char c in s){
            if((c >= 'a' && c <= 'z') || (c>='0' && c<='9')){
                newStr+=c;
            }
        }
        return newStr;
    }

    public static bool checker(string s , int i){
        if(i >= s.Length) return true;

        if(s[i] != s[s.Length - i -1]) return false;

        return checker(s , i+1);

    }

    public bool IsPalindrome(string s) {
        
        string sNew = modifyString(s);

        return checker(sNew , 0);

    }
}
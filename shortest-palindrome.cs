public class Solution {
    public string ShortestPalindrome(string s) {
        if (string.IsNullOrEmpty(s)) return s;

        long prefix = 0, suffix = 0;
        long baseNum = 31;
        int longestPalindromePrefix = 0;
        long power = 1;
        long mod = (int)1e9 + 7;
        int i = 0;

        foreach(char c in s){
            int charValue = (c - 'a' + 1);

            prefix = (prefix * baseNum + charValue) % mod;
            suffix = (suffix + charValue * power) % mod;

            power = (power * baseNum) % mod;

            if(prefix == suffix){
                longestPalindromePrefix = i;
            }
            i++;
        }
        
        string suffixPart = s.Substring(longestPalindromePrefix + 1);
        string reversedSuffix = new string(suffixPart.Reverse().ToArray());
        return reversedSuffix + s;
    }
}

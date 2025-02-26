public class Solution {
    public int LongestValidParentheses(string s) {
        if (string.IsNullOrEmpty(s)) return 0;

        int len = s.Length;
        int[] dp = new int[len];
        int maxLen = 0;

        for (int i = 1; i < len; i++) {
            if (s[i] == ')') {
                if (s[i - 1] == '(') {
                    dp[i] = (i >= 2 ? dp[i - 2] : 0) + 2;
                } else if (i - dp[i - 1] > 0 && s[i - dp[i - 1] - 1] == '(') {
                    dp[i] = dp[i - 1] + 2 + ((i - dp[i - 1] - 2 >= 0) ? dp[i - dp[i - 1] - 2] : 0);
                }
                maxLen = Math.Max(maxLen, dp[i]);
            }
        }
        return maxLen;
    }
}

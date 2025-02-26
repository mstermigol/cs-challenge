public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> romanToInt = new Dictionary<char, int> {
            {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
            {'C', 100}, {'D', 500}, {'M', 1000}
        };

        int result = 0;

        for (int i = 0; i < s.Length; i++) {
            if (i > 0 && romanToInt[s[i]] > romanToInt[s[i - 1]]) {
                result += romanToInt[s[i]] - 2 * romanToInt[s[i - 1]];
            } else {
                result += romanToInt[s[i]];
            }
        }

        return result;
    }
}

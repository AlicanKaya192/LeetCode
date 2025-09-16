public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.Trim();
        int lastspace = s.LastIndexOf(' ');
        return s.Length - lastspace - 1;
    }
}
public class Solution {
    public string LongestPalindrome(string s) {
        return "laval";
    }

static void Main(string[] args)
{
    Solution s = new Solution();

    string input1 = "babad";
    Console.WriteLine("bab = " + s.LongestPalindrome(input1));

     string input2 = "cbbd";
    Console.WriteLine("bb = " + s.LongestPalindrome(input2));
}
}
public class Solution
{
    public string LongestPalindrome(string s)
    {
        // Empty string
        if (s.Length == 0)
        {
            return "";
        }

        string longestPalindrome = "";
        int stringLength = s.Length;

        while (stringLength > 2)
        {
            for (int i = 0; i < stringLength / 2; i++)
            {
                if (s[i] != s[stringLength - i - 1])
                {
                    break;
                }
                return s;
            }
            stringLength -= 1;
        }


        return "laval";
    }

    static void Main(string[] args)
    {
        Solution s = new Solution();

        string input1 = "babad";
        Console.WriteLine("bab = " + s.LongestPalindrome(input1));

        string input2 = "cbbd";
        Console.WriteLine("bb = " + s.LongestPalindrome(input2));

        string input3 = "hhhhhhhhhhhhhhhhhhh";
        Console.WriteLine("bb = " + s.LongestPalindrome(input3));
    }
}




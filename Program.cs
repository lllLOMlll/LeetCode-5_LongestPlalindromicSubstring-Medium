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
        string tempPalindrome = "";
        int stringLength = s.Length;
        int indexTracker = 0;

        while (indexTracker < s.Length / 2)
        {
            while (stringLength > 2)
            {
                for (int i = indexTracker; i < stringLength / 2; i++)
                {
                    if (s[i] != s[stringLength - i - 1])
                    {
                        break;
                    }

                    tempPalindrome = s.Substring(i, stringLength - i);

                    if (tempPalindrome.Length > longestPalindrome.Length)
                    {
                        longestPalindrome = tempPalindrome;
                    }

                }
                stringLength-= 1;
            }
            stringLength = s.Length;
            indexTracker+= 1;
        }



        return longestPalindrome;
    }

    static void Main(string[] args)
    {
        Solution s = new Solution();

        string input1 = "babad";
        Console.WriteLine("babad -> bab = " + s.LongestPalindrome(input1));

        string input2 = "cbbd";
        Console.WriteLine("cbbd -> bb = " + s.LongestPalindrome(input2));

        string input3 = "hhh";
        Console.WriteLine("bb = " + s.LongestPalindrome(input3));

        string input4 = "laval";
        Console.WriteLine("laval -> laval = " + s.LongestPalindrome(input4));
    }
}




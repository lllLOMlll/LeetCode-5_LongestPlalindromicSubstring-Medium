public class Solution
{
   public string LongestPalindrome(string s)
    {
        if (s.Length == 0)
        {
            return "";
        }

        string longestPalindrome = "";
        int stringLength = s.Length;
        int indexTracker = 0;

        while (indexTracker < s.Length)
        {
            while (stringLength > indexTracker)
            {
                bool isPalindrome = true;

                for (int i = 0; i < (stringLength - indexTracker) / 2; i++)
                {
                    if (s[indexTracker + i] != s[stringLength - i - 1])
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                if (isPalindrome)
                {
                    string tempPalindrome = s.Substring(indexTracker, stringLength - indexTracker);
                    if (tempPalindrome.Length > longestPalindrome.Length)
                    {
                        longestPalindrome = tempPalindrome;
                    }
                }
                
                stringLength--; 
            }

            stringLength = s.Length; 
            indexTracker++; 
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




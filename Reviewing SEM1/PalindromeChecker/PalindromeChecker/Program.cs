using System.Text.RegularExpressions;

namespace PalindromeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test cases
            Console.WriteLine(isPalindrome("level")); // Expected output: true
            Console.WriteLine(isPalindrome("hello")); // Expected output: false

            Console.ReadLine();
        }
        static bool isPalindrome(string word)
        {
            int left = 0; // Pointer for the beginning of the string
            int right = word.Length - 1; // Pointer for the end of the string

            // Compare characters from both ends of the string
            while (left < right)
            {
                if (word[left] != word[right])
                {
                    return false; // If any character doesn't match, it's not a palindrome
                }
                left++; // Move the left pointer forward
                right--; // Move the right pointer backward

                //meaning it goes left _   _ right  l   l
                //                 left _ _ right    e e
                //                       _              
            }

            return true;
        }

    }
}
}

using System.Text.RegularExpressions;

namespace RemoveVowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word: ");
            string word = Console.ReadLine();

            Console.WriteLine(removeVowels(word));

            Console.ReadLine();
        }
        static string removeVowels(string word)
        {
            string vowels = "aeiouAEIOU";
            bool containsVowels = false;

            foreach (char c in word)
            {
                if (vowels.Contains(c))
                {
                    containsVowels = true;
                    break;
                }
            }

            if (containsVowels)
            {
                word = Regex.Replace(word, "[aeiouAEIOU]", string.Empty);   //=======> Regex.Replace search for pattern and replaces occurences.
                                                                            //word is the input string, [" "] is the one that you want to look for, string.Empty is what you want it to be replaced
                                                                            //eg Regex.Replace("hello", "l", "a");      hello becomes heaao
                return word;
            }
            else
            {
                return "The word does not contain vowels.";
            }
        }
    }
}

namespace AnagramChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Word: ");
            string wordOne = Console.ReadLine();

            Console.WriteLine("Enter Second Word: ");
            string wordTwo = Console.ReadLine();

            Console.WriteLine(isAnagram(wordOne, wordTwo));

            Console.ReadLine();
        }

        static bool isAnagram(string someStrOne, string someStrTwo) //======> True/False hence static method is bools
        {
            char[] charArrayOne = someStrOne.ToCharArray();
            char[] charArrayTwo = someStrTwo.ToCharArray();

            // Sort both character arrays
            Array.Sort(charArrayOne);
            Array.Sort(charArrayTwo);

            return charArrayOne.SequenceEqual(charArrayTwo);      //======> SequenceEqual returns a true or false value
        }
    }
}

namespace TheWordCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "The anemone, the wild violet, the hepatica, and the funny little curled-up.";

            string[] word = (sentence.ToLower()).Split();   //==========> Splits the sentence into words, case sensitive hence .ToLower()

            int count = 0;

            for (int i = 0; i <= word.Length - 1; i++)
            {
                if (word[i] == "the")
                {
                    count++;
                }
                else
                {

                }
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}

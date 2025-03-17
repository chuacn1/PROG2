using System.Xml.Schema;

namespace ExamScores_Analysis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> scores = new List<int>() { 78, 89, 92, 65, 70, 85, 92, 78, 93, 80 };
            List<int> noDuplicatedScores = scores.Distinct().ToList();                      //It compares each element in the collection and removes any duplicates, keeping only one occurrence of each element.

            int highestScore = scores.Max();

            Console.WriteLine("Scores without duplicates: " + string.Join(", ", noDuplicatedScores));
            Console.WriteLine("Highest Score: " + highestScore);

            Console.ReadLine();

        }
    }
}
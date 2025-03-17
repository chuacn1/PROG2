namespace CityPopulation_Analysis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> cityPopulations = new List<int>() { 5000000, 3000000, 1200000, 8000000, 2000000, 4500000, 6000000 };
            IEnumerable<int> top3 = cityPopulations.OrderByDescending(top => top).Take(3).ToList();

            int total = cityPopulations.Sum();

            Console.WriteLine(total);
        }
    }
}

namespace SumEvenNumbers_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 4, 7, 8, 11, 12, 15, 16, 19, 20 };

            IEnumerable<int> query = numbers.Where(num => num % 2 == 0);             // or just do this: int sumOfEvenNumbers = numbers.Where(num => num % 2 == 0).Sum();
                                                                                     //.Select(num => num);    .Select is if you want to change the values in the collection

            int total = 0;
            foreach (int num in query)
            {
                total += num;
            }

            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
namespace doubleArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] doubles = { 45.3, 67.5, -45.6, 20.34, -33.0, 45.6 };
            double sum, average;

            sum = doubles.Sum();
            average = sum / doubles.Length;

            Console.WriteLine($"The sum of 45.3, 67.5, -45.6, 20.34, -33.0, 45.6 is: {sum:F1}");
            Console.WriteLine($"The average of 45.3, 67.5, -45.6, 20.34, -33.0, 45.6 is : {average:F1}");
            Console.ReadLine();            
        }
    }
}

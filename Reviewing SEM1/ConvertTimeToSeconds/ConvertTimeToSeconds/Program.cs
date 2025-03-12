namespace ConvertTimeToSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hour: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nTotal: {convert(hours, minutes)} seconds");
            Console.ReadLine();
        }

        static int convert(int hours, int minutes)
        {
            int secondsh = hours * 3600;
            int secondsm = minutes * 60;

            int total = secondsh + secondsm;

            return total;
        }
    }
}


namespace PrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isPrime(num));
            Console.ReadLine();
        }

        static bool isPrime(int num)
        {
            if (num <= 1)
            {
                return false; // Numbers less than or equal to 1 are not prime
            }

            // Check divisibility from 2 to the square root of num
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false; // num is divisible by i, so it's not prime
                }
            }

            return true; // num is prime
        }
    }
}

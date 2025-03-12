namespace return_num.ToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //from 1 to 16
            for (int i = 1; i < 16; i += 2)
            {
                Console.WriteLine(Fizzbuzz(i));
            }

            Console.ReadLine();
        }
        static string Fizzbuzz(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (num % 3 == 0)
            {
                return "Fizz";
            }
            else if (num % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return num.ToString();      //just return num into a string and its gonna display it as a number in the loop
            }
        }
    }
}

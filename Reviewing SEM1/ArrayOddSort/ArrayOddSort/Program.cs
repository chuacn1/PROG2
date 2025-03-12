namespace ArrayOddSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 21, 19, 68, 55, 42, 12 };

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    Console.WriteLine(nums[i]);
                }
            }

            Array.Sort(nums); //=============================> does bubble sort in ascending order
                              //=============================> if wanna do descending order, do Array.Sort(ascending) and then Array.Reverse(ascending).ToArray();

            Console.WriteLine("\nSorted array:");
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
    }
}

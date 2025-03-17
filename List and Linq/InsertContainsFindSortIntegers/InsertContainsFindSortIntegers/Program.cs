namespace InsertContainsFindSortIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 10, 20, 30, 40, 50 };


            //=================INSERT================//
            nums.Insert(1, 25);
            Console.WriteLine(string.Join(", ", nums));              // <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<//                          
            Console.ReadLine();

            Console.WriteLine();


            //=================CONTAINS================//
            bool hasNumber35 = nums.Contains(35);
            Console.Write(hasNumber35);
            Console.ReadLine();

            Console.WriteLine();


            //=================FIND================//
            int firstNumberGreaterThan30 = nums.Find(num => num > 30);
            Console.Write(firstNumberGreaterThan30);
            Console.ReadLine();

            Console.WriteLine();

            //=================SORT================//
            nums.Sort();

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();





        }
    }
}
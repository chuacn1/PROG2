namespace TemperatureAnalysis_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> temperatures = new List<double>() { 24.5, 23.8, 25.3, 22.6, 26.1, 27.5, 21.9 };

            double avg;

            /*
            for (int i = 0; i < temperatures.Count; i++)
            {
                total += temperatures[i];    
            } 
            */


            double total = temperatures.Sum(); ///////////////////////////////////////////////////////

            avg = total / temperatures.Count;

            Console.WriteLine($"Total Temperature: {total}\nAverage: {avg}");

            double highestnumber = temperatures.Max();

            IEnumerable<double> query = temperatures.Where(temp => temp > 25)
                                                    .OrderBy(temp => temp);

            List<double> above25 = new List<double>(query);

            Console.WriteLine(string.Join(", ", above25));

            /*
             List<double> above25 = new List<double>();

              {
                total += temp;
                    if (temp > highest)
                    {
                        highest = temp;
                    }
                    if (temp > 25)
                    {
                        above25.Add(temp);
                    }
              }
            */

            Console.ReadLine();


        }
    }
}
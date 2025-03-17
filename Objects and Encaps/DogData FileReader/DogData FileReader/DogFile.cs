using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DogData_FileReader
{
    public class DogFile
    {
        public void WriteDog()
        {
            StreamWriter sw = new StreamWriter(@"dogs.txt");
            {
                // Writing data to the file
                sw.WriteLine("Scooby-Doo,2");
                sw.WriteLine("Astro,5");
                sw.WriteLine("Bolt,10");
                sw.WriteLine("Augie,6");
                sw.WriteLine("Dixie,9");

                sw.Close();
            }
        }
    }
}

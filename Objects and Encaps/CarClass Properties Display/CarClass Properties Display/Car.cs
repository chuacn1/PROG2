using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass_Properties_Display
{
    public class Car
    {
        private string make;
        private string model;
        private int year; 

        public Car (string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
    }
}

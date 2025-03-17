using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.cs
{
    public class Chair
    {
        public string material;
        public string color;
        public int height;

        public Chair (string material, string color, int height)
        {
            this.material = material;
            this.color = color;
            this.height = height;
        }

        public string DisplayInfo()
        {
            return $"Chair Information:\nMaterial: {material}\nColor: {color}\nHeight: {height} cm";
        }



    }
}

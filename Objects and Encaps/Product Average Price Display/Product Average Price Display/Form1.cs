using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Average_Price_Display
{
    public partial class Form1 : Form
    {
        private static List<Product> products; 
        public Form1()
        {
            InitializeComponent();

            products = new List<Product>() 
            {
                new Product("Apple", 1.99),
                new Product("Banana", 2.99),
                new Product("Orange", 3.99)
            };

            double averagePrice = products.Average(p => p.Price);

            label1.Text = $"Average Price: ${averagePrice:F2}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

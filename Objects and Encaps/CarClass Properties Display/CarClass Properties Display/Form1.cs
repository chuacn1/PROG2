using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarClass_Properties_Display
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Car car = new Car("Toyota", "Camry", 2020);
            label2.Text = $"{car.Make} {car.Model} {car.Year}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

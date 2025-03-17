using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace DogData_FileReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DogFile file = new DogFile();
            file.WriteDog(); // Writing data to dogs.txt

            // After writing the file, read the data and display it
            ReadDisplay();

        }
        private void ReadDisplay()
        {
            List<Dog> dogs = new List<Dog>();
            try
            {
                // Read all lines from the dogs.txt file
                string[] lines = File.ReadAllLines(@"dogs.txt");

                // Process each line to create Dog objects
                foreach (string line in lines)
                {
                    // Split the line into parts (name and age)
                    var parts = line.Split(',');

                    if (parts.Length == 2 && int.TryParse(parts[1], out int age))
                    {
                        // Create a new Dog object
                        Dog dog = new Dog(parts[0].Trim(), age);

                        // Add the Dog object to the list
                        dogs.Add(dog);
                    }
                    else
                    {
                        // Log invalid format
                        Console.WriteLine("Invalid line format: " + line);
                    }
                }

                // Display the list of dogs in a DataGridView (assuming you have a DataGridView control)
                dataGridView1.DataSource = dogs;
            }
            catch (Exception ex)
            {
                // Handle any exceptions (e.g., file not found or read error)
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

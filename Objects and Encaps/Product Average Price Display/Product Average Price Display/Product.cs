// Create a new file called Product.cs. Copy and paste the following code into it
using System.Collections.Generic;

public class Product
{
    private string name;
    private double price;

    public Product(string name, double price)
    {
        this.name = name;
        this.price = price;
    }

    public string Name { get => name; set => name = value; }
    public double Price { get => price; set => price = value; }
}


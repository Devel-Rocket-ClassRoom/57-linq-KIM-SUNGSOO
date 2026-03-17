using System;
using System.Collections.Generic;
using System.Text;


class Product
{
    public string Name { get; }
    public string Category { get; }
    public int Price { get; }

    public Product(string name, string category, int price)
    {
        Name = name;
        Category = category;
        Price = price;
    }

}
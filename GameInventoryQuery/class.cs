using System;
using System.Collections.Generic;
using System.Text;

class GameItem
{
    public string Name { get; }
    public string Type { get; }
    public string Grade { get; }
    public int Price { get; }
    public int Quantity { get; }

    public GameItem(string name, string type,
        string grade, int price, int quantity)
    {
        Name = name;
        Type = type;
        Grade = grade;
        Price = price;
        Quantity = quantity;
    }


    
    
}
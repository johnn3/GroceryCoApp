using System;

interface GroceryItem
{
    string name { get; }
    decimal price { get; }
    bool Compare(string name);
}
public class Item : GroceryItem
{
    private string _name;
    private decimal _price;

    public Item (string name, decimal price)
    {
        _name = name.ToUpper();
        _price = price;
    }

    string name
    {
        get
        {
            return _name;
        }
    }

    decimal price
    {
        get
        {
            return _price;
        }
    }

    bool compare (string name)
    {
        return (_name.Equals(name));
    }
    
}

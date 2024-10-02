using System;

public abstract class Product
{
    private string _name;
    private decimal _price;
    private int _stock;

    // Constructor
    public Product(string name, decimal price, int stock)
    {
        _name = name;
        _price = price;
        _stock = stock;
    }
    public string Name
    {
        get { return _name; }
        private set { _name = value; }
    }
    public decimal Price
    {
        get { return _price; }
        private set { _price = value; }
    }
    public int Stock
    {
        get { return _stock; }
        private set { _stock = value; }
    }

    public abstract void DisplayProductInfo();

    public void ApplyDiscount(decimal percentage)
    {
        _price -= _price * (percentage / 100);
    }

    protected void UpdateStock(int newStock)
    {
        _stock = newStock;
    }
}
public interface ISellable
{
    void Sell(int quantity);
    bool IsInStock();
}
public class MobilePhone : Product, ISellable
{
    private string _brand;

    public MobilePhone(string name, decimal price, int stock, string brand)
        : base(name, price, stock)
    {
        _brand = brand;
    }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Mobile Phone: {Name}, Brand: {_brand}, Price: {Price}, Stock: {Stock}");
    }

    public void Sell(int quantity)
    {
        if (Stock >= quantity)
        {
            UpdateStock(Stock - quantity);
            Console.WriteLine($"{quantity} {Name} sold.");
        }
        else
        {
            Console.WriteLine("Not enough stock.");
        }
    }

    public bool IsInStock()
    {
        return Stock > 0;
    }
}
public class Laptop : Product, ISellable
{
    private string _processor;

    public Laptop(string name, decimal price, int stock, string processor)
        : base(name, price, stock)
    {
        _processor = processor;
    }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Laptop: {Name}, Processor: {_processor}, Price: {Price}, Stock: {Stock}");
    }

    public void Sell(int quantity)
    {
        if (Stock >= quantity)
        {
            UpdateStock(Stock - quantity);
            Console.WriteLine($"{quantity} {Name} sold.");
        }
        else
        {
            Console.WriteLine("Not enough stock.");
        }
    }

    public bool IsInStock()
    {
        return Stock > 0;
    }
}
public class Accessory : Product, ISellable
{
    private string _type;

    public Accessory(string name, decimal price, int stock, string type)
        : base(name, price, stock)
    {
        _type = type;
    }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Accessory: {Name}, Type: {_type}, Price: {Price}, Stock: {Stock}");
    }

    public void Sell(int quantity)
    {
        if (Stock >= quantity)
        {
            UpdateStock(Stock - quantity);
            Console.WriteLine($"{quantity} {Name} sold.");
        }
        else
        {
            Console.WriteLine("Not enough stock.");
        }
    }

    public bool IsInStock()
    {
        return Stock > 0;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MobilePhone phone = new MobilePhone("iPhone 14", 1000m, 10, "Apple");

        Laptop laptop = new Laptop("MacBook Pro", 2000m, 5, "M1");

        Accessory accessory = new Accessory("EarPods", 50m, 20, "Headphones");

        phone.DisplayProductInfo();
        laptop.DisplayProductInfo();
        accessory.DisplayProductInfo();

        phone.Sell(2);
        Console.WriteLine(phone.IsInStock() ? "Phone is in stock." : "Phone is out of stock.");

        laptop.Sell(6);
        accessory.Sell(5);

        phone.ApplyDiscount(10);
        accessory.ApplyDiscount(5);

        Console.WriteLine("\nAfter discount:");
        phone.DisplayProductInfo();
        accessory.DisplayProductInfo();
    }
}
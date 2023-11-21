using System;

class Product
{
    protected int pid;
    protected string pname;
    protected double pprice;

    public void ShowDetails()
    {
        Console.WriteLine($"Product ID: {pid}");
        Console.WriteLine($"Product Name: {pname}");
        Console.WriteLine($"Product Price: {pprice:C}");
    }

    public void SetInformation(int id, string name, double price)
    {
        pid = id;
        pname = name;
        pprice = price;
    }
}

class HerbalProduct : Product
{
    private string herbsUsed;
    private DateTime mfDate;
    private DateTime expDate;

    public new void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine($"Herbs Used: {herbsUsed}");
        Console.WriteLine($"Manufacturing Date: {mfDate.ToShortDateString()}");
        Console.WriteLine($"Expiry Date: {expDate.ToShortDateString()}");
    }

    public void SetInformation(int id, string name, double price, string herbs, DateTime manufacturingDate, DateTime expiryDate)
    {
        base.SetInformation(id, name, price);
        herbsUsed = herbs;
        mfDate = manufacturingDate;
        expDate = expiryDate;
    }
}

class Program
{
    static void Main()
    {
        HerbalProduct herbalProduct = new HerbalProduct();
        herbalProduct.SetInformation(1, "Herbal Shampoo", 10.99, "Aloe Vera, Tea Tree", new DateTime(2023, 1, 1), new DateTime(2024, 12, 31));
        herbalProduct.ShowDetails();

        Console.ReadLine();
    }
}

using System;
public class Stock
{
    int id;
    public String name;
    public double currentPrice;
    public Stock(int id, String name, double price)
    {
        this.id = id;
        this.name = name;
        this.currentPrice = price;
    }
}

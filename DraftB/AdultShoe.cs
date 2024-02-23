using System;

public class AdultShoe : Shoe
{
    private int year;
    public AdultShoe(string producer, double size, string color, double price, int year) :
        base(producer, size, color, price)
    {
        this.year = year;
    }
    public AdultShoe()
    {

    }
}

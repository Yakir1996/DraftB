using System;

public class KidShoe : Shoe
{
    private bool orth = false;
    public KidShoe(string producer, double size, string color, double price, bool orth) :
        base(producer, size, color, price)
    {
        this.orth = orth;
    }
    public KidShoe()
    {

    }
}

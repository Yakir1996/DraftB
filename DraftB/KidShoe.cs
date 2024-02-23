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
    public bool GetOrth()
    {
        return orth;
    }
    public override double CalcPrice()
    {
        // return the final price of shoe
        double finalPrice = base.CalcPrice();

        return finalPrice;
    }
}

using System;

public class Shoe
{
    private string producer;// witch producer made this shoe
    private double size;// size can be for ex: 34.5
    private string color;// color of the shoe
    private double price;// price of the shoe for ex 430.9

    public Shoe(string producer, double size, string color, double price)
    {
        this.producer = producer;
        this.size = size;
        this.color = color;
        this.price = price;

    }
    public Shoe()
    {

    }
}

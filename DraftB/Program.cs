using System;

namespace DraftB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! 123");
            int x;
            x = 10;
            Console.WriteLine(x);
            KidShoe kid1 = new KidShoe("nike", 34.5, "blue", 100D, true);
            WomenShoe women1 = new WomenShoe();
            Shoe[] storeShoes = { kid1, women1 }; 
            Console.WriteLine(storeShoes);
        }
    }
}

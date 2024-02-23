using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftB
{
    class WomenShoe : AdultShoe
    {
        private int heel;
        public WomenShoe(string producer, double size, string color, double price, int year, int heel) :
            base(producer, size, color, price, year)


        {
            this.heel = heel;
        }
        public WomenShoe()
        {

        }
        public override double CalcPrice()
        {
            // return the final price of shoe
            double finalPrice = base.CalcPrice();

            return finalPrice;
        }
    }

}


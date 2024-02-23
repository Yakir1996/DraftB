using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MenShoe : AdultShoe
{
    private bool work;
    public MenShoe(string producer, double size, string color, double price, int year, bool work) :
        base(producer, size, color, price, year)
    {
        this.work = work;
    }
    public MenShoe()
    {

    }


}





using System;

public class Storage
{

    // לבנות מערך ששומר את הנעליים הקיימים במחסן
    private Shoe[] shoes = new Shoe[0];
    public Storage(Shoe[] shoes)
    {
        this.shoes = shoes;

    }
    public int OrfeKidShoe()
    {
        int cnt = 0;
        for (int i = 0; i < shoes.Length; i++)
        {
            if (shoes[i] is KidShoe)
            {
                if (((KidShoe)shoes[i]).GetOrth())
                {
                    cnt++;
                }
                
            }
        }
        return cnt;

    }
    public Storage()
    {

    }
}

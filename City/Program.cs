using System;

namespace City
{

    public abstract class Building
    {
        public  int houseSize;
        public  Boolean parking = false;

        public Building(int houseSize)
        {
            this.houseSize = houseSize;
            if (houseSize => 20)
            {
                parking = true;
            }
        }

        public abstract Boolean canPark();
        

    }   

    public class House : Building
    {
        public House(int houseSize) : base(houseSize)
        {
        }

        public override bool canPark()
        {
            if (parking)
            {
                return true;
            }
            else
                return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           House h = new House(54);
            Console.WriteLine(h.canPark());
        }
    }
}

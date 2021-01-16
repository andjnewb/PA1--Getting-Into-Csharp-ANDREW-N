using System;
using System.Collections.Generic;
using System.Text;

namespace PA1__Getting_Into_Csharp__ANDREW_N_
{
    class Horse : Item
    {
        //A horse, with some variables to describe it.

        string Pattern;
        string PrimaryColor;
        int Age;

        public Horse() : base()
        {
            base.setType("Horse");
            Pattern = "bay blanket";
            Age = 1;
        }

        public Horse(string sType, string sName, int sQuantity, double sPrice, string sPattern, string sPrimaryColor, int sAge) : base(sType, sName, sQuantity, sPrice)
        {
            Pattern = sPattern;
            PrimaryColor = sPrimaryColor;
            Age = sAge;
        }

        public override double checkPrice()
        {
            //Return the price of the item using the base class' function
            double returnPrice = base.checkPrice();
            return returnPrice;
        }

        public override void printInfo()
        {
            base.printInfo();

            Console.Write("Pattern: ");
            Console.WriteLine(Pattern);

            Console.Write("Primary color: ");
            Console.WriteLine(PrimaryColor);

            Console.Write("Age: ");
            Console.WriteLine(Age);

        }

        public override int purchase(int amount)
        {
            return base.purchase(amount);
        }
    }
}

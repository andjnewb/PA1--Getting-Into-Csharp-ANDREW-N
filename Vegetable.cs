using System;
using System.Collections.Generic;
using System.Text;

namespace PA1__Getting_Into_Csharp__ANDREW_N_
{
    public class Vegetable : Item
    {
        //This class declares a vegetable, which inherits from item.
        private string Color;

        //Constructors.
        public Vegetable() : base()
        {
            //Same as Item's default constructor, but its a veggie so we have to specify that!
            base.setType("Vegetable");//Didn't like having to make a setter just for this, will look for better solution
            Color = "default";
        }

        public Vegetable(string sType, string sName, int sQuantity, double sPrice, string sColor) : base(sType, sName,sQuantity,sPrice)
        {
            //Here we can call Item's paramterized constructor to save us some coding!
            Color = sColor;
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

            Console.Write("Vegetable color: ");
            Console.WriteLine(Color);
        }

        public override int purchase(int amount)
        {
            return base.purchase(amount);
        }



    }
}

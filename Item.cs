using System;
using System.Collections.Generic;
using System.Text;

namespace PA1__Getting_Into_Csharp__ANDREW_N_
{
    public abstract class Item
    {
        //This class is meant to be overriden. It is not meant to be used on its own.
        //2 constructors, one for default and one for an item. Not necessary for an abstract class but I still included them.

        private string Type;//Type of item
        private string Name;//Name of item
        private int Quantity;//Amount of item
        private double Price;//Price of item

        //Constructors
        public Item()
        {
            //Default values if an Item is decalred with no parameters.
            Type = "default";
            Name = "default";
            Quantity = 1;
            Price = 1;
        }

        public Item(string sType, string sName, int sQuantity, double sPrice)
        {
            //Declare the item based on the given parameters

            Type = sType;
            Name = sName;
            Quantity = sQuantity;
            Price = sPrice;
        }

        //Will be overriden
        public virtual double checkPrice()
        {
            return Price;
        }
        public virtual void printInfo()
        {
            Console.Write("Item name: ");
            Console.WriteLine(Name);

            Console.Write("Item type: ");
            Console.WriteLine(Type);

            Console.Write("Item quantity available: ");
            Console.WriteLine(Quantity);

            Console.Write("Item price per unit: ");
            Console.WriteLine(Price);
        }

        public virtual void setType(string toSet)
        {
            Type = toSet;
        }

        public void setQuantity(int amount)
        {
            Quantity += amount;
        }

        public string getType()
        {
            return Type;
        }

        public string getName()
        {
            return Name;
        }

        public double getPrice()
        {
            return Price;
        }

        public int getQuantity()
        {
            return Quantity;
        }

        public virtual int purchase(int amount)
        {
            //Returns the amount purchased as well as subtracting the quantity.

            if (amount > Quantity)
            {
                Console.WriteLine("Insufficient stock for requested amount!");
                return 0;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount requested for purchase!(Number must be positive and less than or equal to available stock.)");
                return 0;            
            }

            //We passed the error checking, so let's subtract amount from quantity.
            Quantity -= amount;

            return amount;

        }




    }

}

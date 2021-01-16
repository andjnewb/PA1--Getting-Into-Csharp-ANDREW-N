using System;
using System.Collections.Generic;
using System.Text;

namespace PA1__Getting_Into_Csharp__ANDREW_N_
{


    public class Book : Item
    {
        //Variables
        private string Author;
        private int Pages;

        //Constructors
        public Book() : base()
        {
            base.setType("Book");
            Author = "default";
            Pages = 1;
        }

        public Book(string sType, string sName, int sQuantity, double sPrice, string sAuthor, int sPages) : base(sType, sName, sQuantity, sPrice)
        {
            //Needs additional item details so we set them here.
            Author = sAuthor;
            Pages = sPages;
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

            Console.Write("Book author: ");
            Console.WriteLine(Author);

            Console.Write("Number of pages in book: ");
            Console.WriteLine(Pages);
        }

        public override int purchase(int amount)
        {
            return base.purchase(amount);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PA1__Getting_Into_Csharp__ANDREW_N_
{
    class Store
    {
        //Store will only have a default constructor, and will fill its inventory list with 1 of each item type for testing purposes.

        public List<Item> itemList = new List<Item>();

        public Store()
        {
            itemList.Add(new Book("Book", "The Trial Of Bobbert", 3, 19.99, "L. Ron Hubbard", 999));
            itemList.Add(new Book("Book", "The Fall Of Bobbert", 23, 24.99, "L. Ron Hubbard", 852));
            itemList.Add(new Book("Book", "How To Be A Fake Youtube Self-help Guru", 99, 1000.00, "Tai Lopez", 1));
            itemList.Add(new Vegetable("Vegetable", "Carrot", 45, 0.10, "Orange"));
            itemList.Add(new Vegetable("Vegetable", "Pepper", 22, 0.11, "Green"));
            itemList.Add(new Horse("Horse", "Bailey", 1, 2000.00, "bay blanket", "Brown", 2));
            itemList.Add(new Horse("Horse", "Horsebert", 1, 4563.23, "chestnut blanket", "Black", 5));

        }

        public bool update()
        {
            //This is our main driver. It allows the user to select menu items, and will only return false if the user selects 
            //the quit option. My logic here being that I want the program to continue updating on true and quit on false.

            int menuChoice;

            Console.WriteLine("---MENU---");
            Console.WriteLine("0. List all items");
            Console.WriteLine("1. Add an item");
            Console.WriteLine("2. Check price of item");
            Console.WriteLine("3. List information for a specific item: ");
            Console.WriteLine("4. Purchase an item");
            Console.WriteLine("5. Exit the program.");



            Console.Write("Please enter the number preceding your chosen menu option: ");
            menuChoice = int.Parse(Console.ReadLine());

            switch (menuChoice)
            {
                case 0:
                    printAll();
                    Console.Clear();
                    return true;
                case 1:
                    addItem();
                    Console.Clear();
                    return true;
                case 2:
                    checkPrice();
                    Console.Clear();
                    return true;
                case 3:
                    printItem();
                    Console.Clear();
                    return true;
                case 4:
                    purchaseItem();
                    Console.Clear();
                    return true;
                case 5:
                    return false;
            }
            Console.Clear();
            return true;
        }

        public void addItem()
        {
            Console.Clear();
            //Right now, it only Accepts items of already existing Types
            string typeToSet;
            string itemName;
            int itemQuant;
            double itemPrice;


            //Setting up a list of available item types to make error checking easier.
            List<string> typeList = new List<string>();
            foreach (Item item in itemList)
            {
                typeList.Add(item.getType());
            }


            Console.WriteLine("Available types are: ");
            foreach (Item item in itemList)
            {
                Console.Write(item.getType());
                Console.WriteLine();
            }


            Console.Write("Enter the type of item you would like to add: ");
            typeToSet = Console.ReadLine();

            if (!typeList.Contains(typeToSet))
            {
                Console.WriteLine("Invalid item type.");
                return;
            }

            Console.Write("Please enter the name of the item: ");
            itemName = Console.ReadLine();

            Console.Write("Please enter the quantity you wish to add: ");
            itemQuant = int.Parse(Console.ReadLine());//MSDN says this is the way?

            Console.Write("Please enter the price of the item: ");
            itemPrice = double.Parse(Console.ReadLine());


            //Would like to find a more easily expandable way to do this.
            switch (typeToSet)
            {
                //This switch statement allows us to easily set special attributes for each item type beyond what Item requires
                case "Book":
                    string bookAuthor;
                    int bookPages;

                    Console.Write("Enter the author's name:");
                    bookAuthor = Console.ReadLine();

                    Console.Write("Enter the number of pages in the book: ");
                    bookPages = int.Parse(Console.ReadLine());

                    itemList.Add(new Book(typeToSet, itemName, itemQuant, itemPrice, bookAuthor, bookPages));
                    Console.WriteLine("Press any key to return to menu...");
                    Console.ReadKey();

                    break;

                case "Vegetable":
                    string vegetableColor;

                    Console.Write("Enter the vegetable's color: ");
                    vegetableColor = Console.ReadLine();

                    itemList.Add(new Vegetable(typeToSet, itemName, itemQuant, itemPrice, vegetableColor));
                    Console.WriteLine("Press any key to return to menu...");
                    Console.ReadKey();

                    break;

                case "Horse":
                    string Pattern;
                    string PrimaryColor;
                    int age;

                    Console.Write("Enter the horse's pattern: ");
                    Pattern = Console.ReadLine();

                    Console.Write("Enter the horse's primary color: ");
                    PrimaryColor = Console.ReadLine();

                    Console.Write("Enter the horse's age: ");
                    age = int.Parse(Console.ReadLine());

                    itemList.Add(new Horse(typeToSet, itemName, itemQuant, itemPrice, Pattern, PrimaryColor, age));
                    Console.WriteLine("Press any key to return to menu...");
                    Console.ReadKey();

                    break;

            }
        }

        public void checkPrice()
        {
            //Not sure why we need this and printinfo, so I'm adding extra functionality to make it worthwhile.
            //Here you can check the per unit price of an item as well enter an amount.
            Console.Clear();

            string itemToCheck;
            int quantity;
            List<string> itemNames = new List<string>();

            Console.WriteLine("Available items:");

            foreach (Item item in itemList)
            {
                itemNames.Add(item.getName());
                Console.WriteLine(item.getName());
            }    

            Console.Write("Enter the name of the item you wish to see the price of: ");
            itemToCheck = Console.ReadLine();

            if (!itemNames.Contains(itemToCheck))
            {
                Console.WriteLine("No item was found with that name, press any key to return to menu...");
                Console.ReadKey();
                return;
            }

            Console.Write("Enter a quantity(Enter 1 for per unit price): ");
            quantity = int.Parse(Console.ReadLine());

            foreach (Item item in itemList)
            {
                if (item.getName() == itemToCheck)
                {
                    Console.Write("The price of ");
                    Console.Write(quantity);
                    Console.Write(" (");
                    Console.Write(itemToCheck);
                    Console.Write(") is $");
                    Console.WriteLine(item.getPrice() * quantity);
                    Console.WriteLine("Press any key to return to menu...");
                    Console.ReadKey();
                    return;
                }
            }

            return;


        }

        public void printAll()
        {
            Console.Clear();
            foreach (Item item in itemList)
            {
                item.printInfo();
                Console.WriteLine();

            }
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
        }

        public void printItem()
        {
            //Prints all available information of an item.
            Console.Clear();

            string itemToCheck;
            List<string> itemNames = new List<string>();

            Console.WriteLine("Available items:");

            foreach (Item item in itemList)
            {
                itemNames.Add(item.getName());
                Console.Write(item.getName());
                Console.Write(" - ");
                Console.WriteLine(item.getType());
                
            }

            Console.Write("Enter the name of the item you wish to see the info of: ");
            itemToCheck = Console.ReadLine();

            if (!itemNames.Contains(itemToCheck))
            {
                Console.WriteLine("No item was found with that name, press any key to return to menu...");
                Console.ReadKey();
                return;
            }

            foreach (Item item in itemList)
            {
                if (item.getName() == itemToCheck)
                {
                    item.printInfo();
                    Console.WriteLine("Press any key to return to menu...");
                    Console.ReadKey();
                    return;
                }
            }
        }

        public void purchaseItem()
        {
            //Allows the user to purchase a given quantity of an item.
            Console.Clear();

            string itemToCheck;
            List<string> itemNames = new List<string>();
            int quantity;

            Console.WriteLine("Available items:");

            foreach (Item item in itemList)
            {
                itemNames.Add(item.getName());
                Console.Write(item.getName());
                Console.Write(" - Amount in stock: ");
                Console.WriteLine(item.getQuantity());
            }

            Console.Write("Enter the name of the item you wish to purchase: ");
            itemToCheck = Console.ReadLine();

            if (!itemNames.Contains(itemToCheck))
            {
                Console.WriteLine("No item was found with that name, press any key to return to menu...");
                Console.ReadKey();
                return;
            }

            Console.Write("Enter the quantity of (");
            Console.Write(itemToCheck);
            Console.Write(") you wish to purchase: ");
            quantity = int.Parse(Console.ReadLine());

            

            foreach (Item item in itemList)
            {
                if (item.getName() == itemToCheck)
                {
                    //Do some error checking and stuff
                    if (quantity > item.getQuantity() || quantity <= 0)
                    {
                        Console.WriteLine("Invalid amount requested, press any key to return to menu...");
                        Console.ReadKey();
                        return;
                    }

                    double purchaseTotal = quantity * item.getPrice();

                    Console.Write(quantity);
                    Console.Write(" ");
                    Console.Write(itemToCheck);
                    Console.Write(" purchased for a total of $");
                    Console.WriteLine(purchaseTotal);
                    quantity *= -1;
                    item.setQuantity(quantity);
                    Console.WriteLine("Press any key to return to menu...");
                    Console.ReadKey();


                }
            }


        }
        



    }
}

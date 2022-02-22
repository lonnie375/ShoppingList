using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingListCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use Decimal relating to money
            //You can add in what ever items you want
            //One dictionary is going to hold one item and a dictionary is going to hold another
            //If they order the same thing twice we can just show the repeated option 



            //Welcome them to the market
            Console.WriteLine("Welcome to Guenther's Market!");
            Console.WriteLine(""); 
            //Create row for 'item' and 'price'. 15 spaces in between
            Console.WriteLine("Item               Price");

            //Create line
            Console.WriteLine("=====================================");

            //Create the items in the shopping cart 
            Dictionary<string, decimal> shoppingCart = new Dictionary<string, decimal>();
            shoppingCart.Add("apple", 0.99m);
            shoppingCart.Add("banana", 0.59m);
            shoppingCart.Add("cauliflower", 1.59m);
            shoppingCart.Add("dragonfruit", 2.19m);
            shoppingCart.Add("elderberry", 1.79m);
            shoppingCart.Add("figs", 2.09m);
            shoppingCart.Add("grapefruit", 1.99m);
            shoppingCart.Add("honeydew", 3.49m);

            //Print out the menu item for our shopper!
            Console.WriteLine("apple              " + "$" + shoppingCart["apple"]);
            Console.WriteLine("banana             " + "$" + shoppingCart["banana"]);
            Console.WriteLine("cauliflower        " + "$" + shoppingCart["cauliflower"]);
            Console.WriteLine("dragonfruit        " + "$" + shoppingCart["dragonfruit"]);
            Console.WriteLine("elderberry         " + "$" + shoppingCart["elderberry"]);
            Console.WriteLine("figs               " + "$" + shoppingCart["figs"]);
            Console.WriteLine("grapefruit         " + "$" + shoppingCart["grapefruit"]);
            Console.WriteLine("honeydew           " + "$" + shoppingCart["honeydew"]);

            //Take user input and add it to a list 
            List<string> shoppingList = new List<string>();

            bool choice = true;
            do
            {
                //Ask the user to enter an item name
                Console.Write("What item would you like to order? ");
                string userFirstItem = Console.ReadLine();

                //pull the price for the users selection 
                bool isInCart = shoppingCart.ContainsKey(userFirstItem); 

                if (isInCart)
                {
                    shoppingList.Add(userFirstItem);
                    //Confirm what the shopper selected and list the price 
                    Console.WriteLine($"Adding {userFirstItem} to cart at {shoppingCart[userFirstItem]}");
                }
                else 
                {
                    //Print error message
                    Console.WriteLine("Sorry, we don't have those. Please try again."); 
                }

                //Ask the user if they would like to order anything else
                Console.Write("Would you like to order anything else (y/n)? ");
                string userProgress = Console.ReadLine();

                if (userProgress == "y")
                {
                    //Create row for 'item' and 'price'. 15 spaces in between
                    Console.WriteLine("Item               Price");

                    //Create line
                    Console.WriteLine("=====================================");

                    //Print out the menu item for our shopper!
                    Console.WriteLine("apple              " + "$" + shoppingCart["apple"]);
                    Console.WriteLine("banana             " + "$" + shoppingCart["banana"]);
                    Console.WriteLine("cauliflower        " + "$" + shoppingCart["cauliflower"]);
                    Console.WriteLine("dragonfruit        " + "$" + shoppingCart["dragonfruit"]);
                    Console.WriteLine("elderberry         " + "$" + shoppingCart["elderberry"]);
                    Console.WriteLine("figs               " + "$" + shoppingCart["figs"]);
                    Console.WriteLine("grapefruit         " + "$" + shoppingCart["grapefruit"]);
                    Console.WriteLine("honeydew           " + "$" + shoppingCart["honeydew"]);
                }
                else
                {
                    Console.WriteLine("Thanks for your order!");
                    break; 
                }

            } while (choice == true);

            //Print the users outcome
            Console.WriteLine("Here's what you got: ");

            decimal Total = 0; 

            //List the items that they ordered and list the price 

            foreach (string list in shoppingList)
            {
                Console.WriteLine(list + "     " + shoppingCart[list]);
                Total += shoppingCart[list]; 
            }

            //Calculate the average price of the shoppers order!
            Console.WriteLine($"Your total price is ${Total}");  


        }
    }
}

// Example file for C# Applied Data Structures by Joe Marini
// Programming Challenge: Chapter 2

using System;
using System.Collections.Generic;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Test Code
            ShoppingList list = new();
            list.AddItem("Milk", 2.25, 1);
            list.AddItem("Sugar", 1.75, 2);
            list.AddItem("Bread", 3.25, 1);
            list.AddItem("Butter", 4.95, 1);
            Console.WriteLine($"Items: {list.GetCount()}");

            list.PrintList();

            list.RemoveItem("Bread");
            list.RemoveItem("Sugar");
            list.AddItem("Cookies", 0.50, 4);
            list.AddItem("Oranges", 0.65, 5);
            list.AddItem("Chicken", 8.95, 1);
            Console.WriteLine($"Items: {list.GetCount()}");

            list.PrintList();
        }
    }

    public class ShoppingItem
    {
        public string itemName;
        public double price;
        public int quantity;

        public ShoppingItem(string i, double p, int q)
        {
            itemName = i;
            price = p;
            quantity = q;
        }
    }

    public class ShoppingList
    {
        List<ShoppingItem> mylist = new List<ShoppingItem>(20);

        // TODO: Implement the AddItem function
        public void AddItem(string ItemName, double Price, int Quantity)
        {
            // YOUR CODE GOES HERE
            mylist.Add(new ShoppingItem(ItemName, Price, Quantity));
        }

        // TODO: Implement the RemoveItem function
        public void RemoveItem(string ItemName)
        {
            // YOUR CODE GOES HERE
            ShoppingItem removing = null;
            foreach (ShoppingItem x in mylist)
            {
                if (x.itemName == ItemName)
                {
                    removing = x;
                    break;
                }

                if (removing != null)
                {
                    if (removing.quantity > 1)
                    {
                        removing.quantity--;
                    }

                    else
                    {
                        mylist.Remove(removing);
                    }
                }
            }
        }

        // TODO: Implement the GetCount function
        public int GetCount()
        {
            int count = 0;
            // YOUR CODE GOES HERE
            foreach (ShoppingItem x in mylist)
            {
                count += x.quantity;
            }
            return count;
        }

        public void PrintList()
        {
            foreach (var item in mylist)
            {
                Console.WriteLine($"Item: {item.itemName,10}, Price: {item.price:C}, Quantity: {item.quantity}");
            }
        }
    }
}

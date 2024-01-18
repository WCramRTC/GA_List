using System;
using System.Collections.Generic;

namespace GA_List;

class Program
{
    static List<string> itemList = new List<string>();

    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Display Items in List");
            Console.WriteLine("2. Add Item to List");
            Console.WriteLine("3. Remove Item from List");
            Console.WriteLine("4. Show Count of Items in List");
            Console.WriteLine("5. Clear List");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice (1-6): ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    DisplayItems();
                    break;
                case 2:
                    AddItem();
                    break;
                case 3:
                    RemoveItem();
                    break;
                case 4:
                    ShowCount();
                    break;
                case 5:
                    ClearList();
                    break;
                case 6:
                    exit = true;
                    break;
            }
        }
    }

    static void DisplayItems()
    {
        if (itemList.Count == 0)
        {
            Console.WriteLine("The list is empty.");
        }
        else
        {
            Console.WriteLine("Items in the List:");
            foreach (var item in itemList)
            {
                Console.WriteLine(item);
            }
        }
    }

    static void AddItem()
    {
        Console.Write("Enter an item to add: ");
        string item = Console.ReadLine();
        itemList.Add(item);
        Console.WriteLine($"'{item}' has been added to the list.");
    }

    static void RemoveItem()
    {
        Console.Write("Enter an item to remove: ");
        string item = Console.ReadLine();
        if (itemList.Contains(item))
        {
            itemList.Remove(item);
            Console.WriteLine($"'{item}' has been removed from the list.");
        }
        else
        {
            Console.WriteLine($"'{item}' was not found in the list.");
        }
    }

    static void ShowCount()
    {
        Console.WriteLine($"There are {itemList.Count} items in the list.");
    }

    static void ClearList()
    {
        itemList.Clear();
        Console.WriteLine("The list has been cleared.");
    }
}
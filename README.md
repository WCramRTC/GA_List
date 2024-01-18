# Guided Assignment - List

## Introduction

A list is a common data structure in programming used to store a collection of elements of the same or different data types. Lists are often referred to as arrays or sequences in various programming languages. They allow you to store and manage multiple items in a single container, making it easy to manipulate and work with these items.

Here are explanations for some fundamental list-related operations and concepts:

1. **Add (Insert) Elements to a List:**
   
   - Adding elements to a list typically involves using an "add" or "insert" operation. You can add elements to the end of the list or at a specific position.
   - In C#, for example, you can use the `Add` method to add an element to the end of a `List<T>`. For example:
   
     ```csharp
     List<int> myList = new List<int>();
     myList.Add(1);  // Adds the element 1 to the end of the list.
     ```

2. **Remove Elements from a List:**
   
   - Removing elements from a list allows you to delete items you no longer need.
   - In C#, you can use the `Remove` or `RemoveAt` method to remove elements from a `List<T>`. The `Remove` method removes the first occurrence of a specific element, while the `RemoveAt` method removes an element at a specified index. For example:
   
     ```csharp
     List<string> myStrings = new List<string> { "apple", "banana", "cherry" };
     myStrings.Remove("banana");     // Removes the element "banana" from the list.
     myStrings.RemoveAt(0);          // Removes the first element ("apple") at index 0.
     ```

3. **Count Elements in a List:**
   
   - The count of elements in a list represents the number of items it contains.
   - In C#, you can use the `Count` property of a `List<T>` to get the number of elements in the list. For example:
   
     ```csharp
     List<double> numbers = new List<double> { 1.1, 2.2, 3.3, 4.4, 5.5 };
     int count = numbers.Count; // Gets the count of elements in the list (count = 5).
     ```

4. **Access and Display Elements from a List:**
   
   - To access elements in a list, you can use indexing. Elements in most lists are indexed starting from 0 for the first element.
   - To display elements, you can iterate through the list using loops like `for` or `foreach` and print each element.
   
     ```csharp
     List<int> myList = new List<int> { 10, 20, 30 };
     
     // Accessing and displaying elements using a foreach loop.
     foreach (int item in myList)
     {
         Console.WriteLine(item);
     }
     // Output: 10, 20, 30
     ```

1. **Using Indexing:**

   - You can access elements in a list by specifying the index enclosed in square brackets `[]`. The index indicates the position of the element within the list.
   - In most programming languages, the index starts from 0 for the first element, 1 for the second element, and so on.

   **Example in Python:**

   ```python
   my_list = [10, 20, 30, 40, 50]
   
   # Accessing individual elements by index
   first_element = my_list[0]  # Access the first element (10)
   second_element = my_list[1] # Access the second element (20)
   ```

   **Example in C#:**

   ```csharp
   List<int> myList = new List<int> { 10, 20, 30, 40, 50 };
   
   // Accessing individual elements by index
   int firstElement = myList[0];  // Access the first element (10)
   int secondElement = myList[1]; // Access the second element (20)
   ```

2. **Checking Index Validity:**

   - When accessing elements by index, it's essential to ensure that the index is within the valid range of the list to avoid index out-of-range errors.

   **Example in Python:**

   ```python
   my_list = [10, 20, 30]
   
   if len(my_list) > 2:
       third_element = my_list[2]  # Access the third element (30)
   else:
       print("Index is out of range")
   ```

   **Example in C#:**

   ```csharp
   List<int> myList = new List<int> { 10, 20, 30 };
   
   if (myList.Count > 2)
   {
       int thirdElement = myList[2]; // Access the third element (30)
   }
   else
   {
       Console.WriteLine("Index is out of range");
   }
   ```

Keep in mind that accessing elements by index allows you to retrieve specific elements from a list, but it's important to ensure that the index is valid to avoid runtime errors.

---

## Starter Code

## Replace the code in `Program.cs` with this code.

```csharp
using System;
using System.Collections.Generic;

class Program
{
    // Part 1 - Declare your List here


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

    // 2.
    static void DisplayItems()
    {
        // Add Part 2 code here
    }

    // 3.
    static void AddItem()
    {
        // Add part 3 code here
    }

    // 4.
    static void RemoveItem()
    {
        // Add part 4 code here
    }

    // 5. 
    static void ShowCount()
    {
        // Add part 5 code here
    }


    // 6.
    static void ClearList()
    {
        // Add part 6 code here
    }
}
```

---

## 1. Creating a List\<T\> - Declaring our list

### Add this list above main, look for the `// 1.`
```csharp
    static List<string> itemList = new List<string>();
```



> ### Explaination
***Using a List\<T\> Constructor***
Creates an empty list
```csharp
    List<int> myIntList = new List<int>(); // Empty list
    List<string> myStringList = new List<string>(); // Empty list for strings
```

***Using a Collection Initialization Syntax***
Creates a list with items
```csharp
    List<int> myIntList = new List<int> { 1, 2, 3 }; // List with elements
    List<string> myStringList = new List<string> { "apple", "banana" }; // List with strings
```

---

## 2. Display Items from our list

### Add this code to your Display Items Method

```csharp
static void DisplayItems()
{
    // 1. Check if the list is empty.
    if (itemList.Count == 0)
    {
        // 2. If empty, print a message.
        Console.WriteLine("The list is empty.");
    }
    else
    {
        // 3. If not empty, print the items in the list.
        Console.WriteLine("Items in the List:");
        
        // 4. Iterate through each item in the list.
        foreach (var item in itemList)
        {
            // 5. Print each item.
            Console.WriteLine(item);
        }
    }
}
```

***Run Your Code***
1. Select Add An Item
2. Enter an item to add
3. Select Display Items

> ### Explination

1. Check if the list (`itemList`) is empty by examining its `Count` property.
    - The `itemList.Count` property returns how many items are in the list

2. If the list is empty (Count is 0), print a message indicating that the list is empty.
3. If the list is not empty (Count is not 0), print a header message to indicate that items in the list will be displayed.
4. Use a `foreach` loop to iterate through each item in the list.
    - You can interact with a list like an array.
    - You can use a `foreach` to loop through an List
    - You can use a `for` loop just like a list.

    ```csharp
        for(int i = 0; i < itemList.Count; i++) {
            Console.WriteLine(itemList[i]); // <--- Access an item just like a array
        }
    ```
5. Print each item to the console during the iteration.

This code helps you determine whether a list is empty and, if not, it displays the items within the list.

---

## 3. itemList.Add(item) - Adding an item to the list

## Add This code to the Add Item method
```csharp
static void AddItem()
{
    // 1. Prompt the user to enter an item to add.
    Console.Write("Enter an item to add: ");
    
    // 2. Read the user's input as a string.
    string item = Console.ReadLine();
    
    // 3. Add the entered item to the itemList.
    itemList.Add(item);
    
    // 4. Display a message confirming that the item has been added.
    Console.WriteLine($"'{item}' has been added to the list.");
}
```

> ### Explination


Here's a detailed explanation of each step:

1. The `AddItem` method is defined. This method allows the user to add an item to the `itemList`.

2. It prompts the user to enter an item to add by displaying the message "Enter an item to add: ".

3. It reads the user's input, which is entered via the console, and stores it as a string in the `item` variable.

4. It uses the `.Add` method to add the entered `item` to the `itemList`. The `.Add` method is a built-in method for lists in C#, and it adds the specified element to the end of the list.

5. Finally, it displays a message using `Console.WriteLine` to confirm that the entered item has been successfully added to the list. The message includes the item that was added, enclosed in single quotes, for clarity.

In summary, this code defines a method (`AddItem`) that takes user input, adds it to a list (`itemList`) using the `.Add` method, and provides feedback to the user about the successful addition of the item.

---

## 4. itemList.Remove(item) - Remove selected item from the list

### Add thid code to remove item
```csharp
static void RemoveItem()
{
    // 1. Prompt the user to enter an item to remove.
    Console.Write("Enter an item to remove: ");
    
    // 2. Read the user's input as a string.
    string item = Console.ReadLine();
    
    // 3. Check if the entered item is in the itemList.
    if (itemList.Contains(item))
    {
        // 4. If found, remove the item from the list.
        itemList.Remove(item);
        
        // 5. Display a message confirming the removal.
        Console.WriteLine($"'{item}' has been removed from the list.");
    }
    else
    {
        // 6. If not found, display a message indicating it was not found.
        Console.WriteLine($"'{item}' was not found in the list.");
    }
}
```

> ## Explination

Here's a detailed explanation of each step:

1. The `RemoveItem` method is defined. This method allows the user to remove an item from the `itemList`.

2. It prompts the user to enter the item they want to remove by displaying the message "Enter an item to remove: ".

3. It reads the user's input, which is entered via the console, and stores it as a string in the `item` variable.

4. It checks if the entered `item` is present in the `itemList` using the `.Contains` method. If the item is found in the list, it proceeds to remove it.

5. If the item is found and removed, the method displays a message confirming the removal. The message includes the removed item's name enclosed in single quotes for clarity.

6. If the item is not found in the list, the method displays a message indicating that the item was not found.

In summary, this code defines a method (`RemoveItem`) that allows the user to input an item to remove from a list (`itemList`). It checks if the item exists in the list using `.Contains`, removes it if found, and provides feedback to the user about whether the removal was successful or if the item was not found in the list.

---


## 5. Item.Count - How many items in the list

### Write This Code In Show Count
```csharp
static void ShowCount()
{
    // Using string interpolation to display the count of items in the list.
    Console.WriteLine($"There are {itemList.Count} items in the list.");
}
```

> ## Explination

- The `ShowCount` method is defined as a static method, which means it doesn't require an instance of the class to be called. It simply counts and displays information about the `itemList`.

- Inside the method, a message is printed to the console using `Console.WriteLine()`. This message uses string interpolation (indicated by the `$` symbol followed by curly braces `{}`) to dynamically insert the count of items in the `itemList` into the string.

- `itemList.Count` is used to retrieve the number of items currently stored in the `itemList`. The `Count` property is a built-in property of the `List<T>` class in C#, which returns the number of elements in the list.

- The message displayed to the console will look like this: "There are X items in the list," where X represents the actual count of items in the `itemList`.

In summary, the `ShowCount` method is a straightforward utility method that retrieves the count of items in the `itemList` and displays it to the console in a user-friendly message. It provides users with information about how many items are currently stored in the list.



---

## 6. itemList.Clear() - Emptying Your List

### Add This Code
```csharp
static void ClearList()
{
    // 1. Clear all items from the itemList.
    itemList.Clear();
    
    // 2. Display a message confirming that the list has been cleared.
    Console.WriteLine("The list has been cleared.");
}
```

> ## Explination

Here's a detailed explanation of each step:

1. The `ClearList` method begins by calling the `Clear` method on the `itemList`. The `Clear` method is a built-in method of the `List<T>` class in C#. When invoked, it removes all elements from the list, effectively emptying it.

2. After clearing the list, the method proceeds to display a message to the console using `Console.WriteLine()`. The message simply states, "The list has been cleared," to inform the user that all items previously in the list have been removed.

In summary, the `ClearList` method provides a way to completely empty the `itemList` by calling the `Clear` method. It then confirms the list's successful clearing by displaying a message to the user. This can be useful when you want to start with an empty list or reset the list's contents.
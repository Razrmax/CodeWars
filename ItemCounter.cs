using System;
using System.Collections.Generic;

// https://www.codewars.com/kata/587f279fadc9c5c1c400008e/train/csharp

public class ItemCounter
{
    private readonly string[] items;
    private readonly Dictionary<string, int> _itemCounts = new Dictionary<string, int>();
    public Dictionary<string, int> distinctItems = new Dictionary<string, int>();


    //returns a count of all of the UNIQUE items the counter was constructed with
    public int DistinctItems
    {
        get { return distinctItems.Count; }
    }

    public int GetCount(string item)
    {
        try
        {
            return distinctItems[item];
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Error, null parameter sent!");
            return -1;
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine("Error, no {0} exists!", item);
            return -1;
        }
    }

    public bool HasItem(string item)
    {
        try
        {
            return distinctItems.ContainsKey(item);

        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Error, null parameter sent!");
            return false;
        }
    }


    public ItemCounter(string[] items)
    {
        try
        {
            this.items = items;

            for (int i = 0; i < items.Length; i++)
            {
                string currentValue = items[i];

                try
                {
                    distinctItems.Add(currentValue, 1);
                }
                catch (ArgumentException)
                {
                    if (currentValue != null)
                    {
                        distinctItems[currentValue] = distinctItems[currentValue] + 1;
                    }
                    else
                    {
                        Console.WriteLine("Null value passed!");
                    }
                }
            }

        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Null value exception");
        }
    }
}

class ItemCounterDriver
{
    static void Main()
    {
        string[] input = { "Apple", "Orange", "Pear", "Apple" };
        ItemCounter itemCounter = new ItemCounter(input);
        foreach (var item in itemCounter.distinctItems)
        {
            Console.WriteLine("{0}:{1}", item.Key, item.Value);
        }
        Console.WriteLine("Total distinct items: {0}", itemCounter.DistinctItems);
        Console.WriteLine("\"Apple\" instances: {0}", itemCounter.GetCount("Apple"));
        Console.WriteLine("\"Orange\" instances: {0}", itemCounter.GetCount("Orange"));
        Console.WriteLine("\"Blank\" instances: {0}", itemCounter.GetCount("Blank"));
        Console.WriteLine("\"null\" instances: {0}", itemCounter.GetCount(null));
        Console.WriteLine("Contains key \"Lemon\": {0}", itemCounter.HasItem("Lemon"));
        Console.WriteLine("Contains key \"null\": {0}", itemCounter.HasItem(null));
        Console.ReadLine();
    }
}
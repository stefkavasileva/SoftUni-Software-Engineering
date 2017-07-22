using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Startup
{
    public static void Main()
    {
        var addCollection = new AddCollection();
        var addRemoveCollection = new AddRemoveCollection();
        var myList = new MyList();

        var itemsToAdd = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var amountOfRemoveOperations = int.Parse(Console.ReadLine());

        var indexes = new List<int>();
        var removedElements = new List<string>();

        AddItem(addCollection, itemsToAdd, indexes);
        AddItem(addRemoveCollection, itemsToAdd, indexes);
        AddItem(myList, itemsToAdd, indexes);

        RemoveItem(addRemoveCollection, amountOfRemoveOperations, removedElements);
        RemoveItem(myList, amountOfRemoveOperations, removedElements);

        PrintAddResults(indexes, itemsToAdd.Length);
        PrintRemoveResults(removedElements, amountOfRemoveOperations);
    }

    private static void AddItem(Collection collection, string[] itemsToAdd, List<int> indexes)
    {
        foreach (var item in itemsToAdd)
        {
            indexes.Add(collection.Add(item));
        }
    }

    private static void RemoveItem(Collection collection, int count, List<string> removedElementsList)
    {
        for (int i = 0; i < count; i++)
        {
            removedElementsList.Add(collection.Remove());
        }
    }

    private static void PrintRemoveResults(List<string> removedElements, int amountOfRemoveOperations)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < removedElements.Count - 1; i += amountOfRemoveOperations)
        {
            var elementToJoin = removedElements.Skip(i).Take(amountOfRemoveOperations);
            sb.AppendLine($"{string.Join(" ", elementToJoin)}");
        }

        Console.WriteLine(sb.ToString().Trim());
    }

    private static void PrintAddResults(List<int> indexes, int count)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < indexes.Count - 1; i += count)
        {
            var elementToJoin = indexes.Skip(i).Take(count);
            sb.AppendLine($"{string.Join(" ", elementToJoin)}");
        }

        Console.WriteLine(sb.ToString().Trim());
    }
}


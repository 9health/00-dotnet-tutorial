using MySortingMachine;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsumerApp;

public class Program
{
    private static readonly SortableCollection _data = new SortableCollection(new[] { "Walden", "Self-Reliance", "flow - the psychology of happiness", "dolor", "sit", "amet." });

    public static void Main(string[] args)
    {
        string input = default;
        do
        {
            Console.WriteLine("Options:");
            Console.WriteLine("1: Display the items");
            Console.WriteLine("2: Sort the collection");
            Console.WriteLine("3: Select the sort ascending strategy");
            Console.WriteLine("4: Select the sort descending strategy");
            Console.WriteLine("0: Exit");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Please make a selection: ");
            input = Console.ReadLine();

            Console.Clear();
            var output = input switch
            {
                "1" => PrintCollection(),
                "2" => SortData(),
                "3" => SetSortAsc(),
                "4" => SetSortDesc(),
                "0" => "Existing",
                _ => "Invalid input!"
            };
            Console.WriteLine(output);
            Console.WriteLine("Press **enter** to continue.");
            Console.ReadLine();
        } while (input != "0");
    }

    private static string SetSortAsc()
    {
        //changing the value of the SortStrategy property leads to a change of
        //behavior of the Sort() method
        _data.SortStrategy = new SortAscendingStrategy();
        return "The sort strategy is now Descending!";
    }

    private static string SetSortDesc()
    {
        //changing the value of the SortStrategy property leads to a change of
        //behavior of the Sort() method
        _data.SortStrategy = new SortDescendingStrategy();
        return "The sort strategy is now Descending!";
    }

    private static string SortData()
    {
        try
        {
            _data.Sort();
            return "Data sorted!";
        }
        catch(NullReferenceException ex)
        {
            return ex.Message;
        }
    }

    private static string PrintCollection()
    {
        var sb = new StringBuilder();
        foreach(var item in _data.Items)
        {
            sb.AppendLine(item);
        }
        return sb.ToString();
    }
}


//========================================================================
//
//  Author: 9Health
//
//  Changelog:
//
//    2022/Oct/06  v0.1.0  Add database output in JSON format
//
//========================================================================

using System.Collections;
using System.Text.Json;

public class _201_libs {

    public static void PrintValues(Object[] myArr)
    {
        foreach (Object i in myArr)
        {
            Console.Write("\t{0}", i);
        }
        Console.WriteLine();
    }

    public static void PrintValues(int[] myArr)
    {
        foreach (int i in myArr)
        {
            Console.Write("\t{0}", i);
        }
        Console.WriteLine();
    }

    public static void PrintValues(List<int> myArr)
    {
     // foreach (int i in myArr)
        foreach (var i in myArr)
        {
            Console.Write("\t{0}", i);
        }
        Console.WriteLine();
    }

    public static void PrintValues(List<NHFoodVerB> foodList)
    {
        foreach (var food in foodList)
        {
            Console.Write("\t{0}", food.FoodViews);
        }
        Console.WriteLine();
    }

    public static void PrintValues(MealVerA meal)
    {
        foreach (var food in meal)
        {
            Console.Write("\t{0}", food);
        }
        Console.WriteLine();
    }

    public static void PrintValues(IEnumerable collection)
    {
        foreach (var item in collection)
        {
            Console.Write("\t{0}", item);
        }
        Console.WriteLine();
    }

    public static void PrintValues(MealVerB meal)
    {
        foreach (var food in meal)
        {
            Console.Write("\t{0}", food);
        }
        Console.WriteLine();
    }

    public static void PrintValuesJson(Object obj)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(obj, options);

        Console.WriteLine($"{jsonString}");
    }

    public static void PrintValuesJson(IEnumerable objList)
    {
        foreach (var obj in objList) {
            PrintValuesJson(obj);
        }
    }


    public static void EnterAnyInput()
    {
        Console.Write("Enter any character to continue: ");
        var charInput = Console.ReadLine();
        Console.WriteLine($"{charInput}");
    }

    public static void PrintDatabaseJSON()
    {

        using var db = new FoodModel();

        var allFoodQuery = db.Foods.OrderBy( f => f.FoodId ) ;

        PrintValuesJson( allFoodQuery );

        var allMealQuery = db.Meals.OrderBy( f => f.MealId ) ;

        PrintValuesJson( allMealQuery );

    }

}


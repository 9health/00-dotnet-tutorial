
using System.Collections;

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


}



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

}

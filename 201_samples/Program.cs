
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 201 Samples at here

_201_samples._01_test_nullable();

public class _201_samples {

    // Test nullable type int?
    public static void _01_test_nullable() {

        int  a;
        int? ax;

        a = 4;
        Console.WriteLine($"a = {a}. Expect a = 4");

        ax = null;
        Console.WriteLine($"ax = {ax}. Expect ax = (null)");

    }

    // Try exception if null is assigned to int
    // New idea is using random to trick the compiler!!!
    public static void _02_test_nullable_exception() {

        int  a;

        // 2022/Sep/06: Build failed.
        // try {
        //    a = null;
        // }
        // catch (Exception e) {
        //     Console.WriteLine("Exception happened.");
        // }

    }

}


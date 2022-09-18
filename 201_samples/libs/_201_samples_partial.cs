
public partial class _201_samples {

    // Try read characters from terminal
    public static void _80_test_cmd_read() {
        var line = "";
        Console.WriteLine("Enter 'q' to exit.");
        while ( line != "q" ) {
            line = Console.ReadLine();
            Console.WriteLine($"[{DateTime.Now}] Input: {line}");
        }
    }

    // Try method named arguments
    public static void _96_printInfo(int foodID, string foodName, int foodTime) {
        Console.WriteLine($"Food ID:   {foodID}");
        Console.WriteLine($"Food Name: {foodName}");
        Console.WriteLine($"Food Time: {foodTime}");
    }

    public static void _90_test_named_arguments() {
        _96_printInfo(
            foodID:   1,
            foodName: "Rau muong luoc",
            foodTime: 10
        );
    }

    // Try preprocessor directives
    public static void _100_test_prep_directives() {
#line 200 "Partial Class 201 Samples"
        int? foodID;
#line default
        int foodName;
    }

}



using System.Text.Json;

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
        string foodName;
#warning [WARN] foodTime is unused
        int foodTime;
// #pragma warning disable 304, CS0168
#pragma warning disable
        int foodViews;
        int foodLikes;
#pragma warning restore
        int ingredientNumber;
    }

    // Try attributes
    public static void _110_test_attributes() {

        var myMealD = new MealVerD();

        myMealD.AddFood( 1, "Trung ran"  , 10 ) ;

        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(myMealD.foods, options);

        Console.WriteLine($"{jsonString}");

    }

    // Get attributes
    public static void _111_test_attributes_get() {
        var myMealE = new MealVerE();

        myMealE.AddFood( 2, "Rau cai xao", 15 ) ;

        NHFoodVerEAttribute MyAttribute = ( NHFoodVerEAttribute ) Attribute.GetCustomAttribute( typeof(MealVerE), typeof(NHFoodVerEAttribute) );
        
        if ( MyAttribute == null ) {
            Console.WriteLine($"Attribute not found");
        } else {
            Console.WriteLine($"Author:   {MyAttribute.Author}  ");
            Console.WriteLine($"Version:  {MyAttribute.Version} ");
            Console.WriteLine($"Reviewed: {MyAttribute.Reviewed}");
        }

    }

}

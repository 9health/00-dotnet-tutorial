//========================================================================
//
//  Author: 9Health
//
//  Changelog:
//
//    2022/Sep/27  v0.1  Add 140, 150, 160 testcases
//
//========================================================================

using System.Text.Json;

public partial class _201_samples_class {

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

    // Try Expression Body Definition
    public static void IncreaseFoodId(NHFoodVerE food) => food.FoodId += 1;

    public static void _120_test_expr_body_def() {
        var myMealE = new MealVerE();

        myMealE.AddFood( 4, "Nuoc mam"        , 4  ) ;

        IncreaseFoodId(myMealE.foods[0]);

        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(myMealE.foods, options);

        Console.WriteLine($"{jsonString}");

        Console.WriteLine("Expect FoodId = 5");
    }

    // Try using statement
    public static void _130_test_using_statement() {

        using ( var myMealG = new MealVerG() ) {
            myMealG.AddFood( 8, "Cha cuon la lot" , 30 ) ;
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(myMealG.foods, options);

            Console.WriteLine($"{jsonString}");
        }

        // Build error!!!
        //   error CS0103: The name 'myMealG' does not exist in the current context
        //
        // IncreaseFoodId(myMealG.foods[0]);

        // var optionsVerG = new JsonSerializerOptions { WriteIndented = true };
        // string jsonStringVerG = JsonSerializer.Serialize(myMealG.foods, optionsVerG);

        // Console.WriteLine($"{jsonStringVerG}");

    }

    // Try switch expression
    private static string FoodTimeCheck(NHFoodVerC foodVerC) => foodVerC.FoodTime switch {
        >   0 and <  5   =>  "Nhanh"       ,
        >=  5 and < 15   =>  "Binh thuong" ,
        _                =>  "Lau"         ,
    };

    public static void _140_test_switch_expression() {

        _99_mealCreate();

        foreach (var food in mealSampleC.foods) {
            Console.WriteLine($"[{food.FoodId,+2}] {food.FoodName,-20} : {FoodTimeCheck(food)}");
        }

    }

    // Try is operator
    private static bool IsFoodTimeLong(NHFoodVerC foodVerC) => foodVerC is {
         FoodTime: >= 15
    };

    private static bool IsFoodTimeNotLong(NHFoodVerC foodVerC) => foodVerC is not {
         FoodTime: >= 15
    };

    public static void _150_test_is_operator() {

        _99_mealCreate();

        Console.WriteLine("[FoodID] FoodName : IsFoodTimeLong()");

        foreach (var food in mealSampleC.foods) {
            Console.WriteLine($"[{food.FoodId,+2}] {food.FoodName,-20} : {food.FoodTime,2} ({IsFoodTimeLong(food)})");
        }

        Console.WriteLine("");

        Console.WriteLine("[FoodID] FoodName : IsFoodTimeNotLong()");

        foreach (var food in mealSampleC.foods) {
            Console.WriteLine($"[{food.FoodId,+2}] {food.FoodName,-20} : {food.FoodTime,2} ({IsFoodTimeNotLong(food)})");
        }


    }

    // Try when keyword guard
    private static string FoodTimeCheckTop5(NHFoodVerC foodVerC) => foodVerC switch {
        { FoodTime: > 15  } when ( foodVerC.FoodId <= 5 )   =>  "Lau"         ,
        { FoodTime: > 5   } when ( foodVerC.FoodId <= 5 )   =>  "Binh thuong" ,
        { FoodTime: _     } when ( foodVerC.FoodId <= 5 )   =>  "Nhanh"       ,
        _                                                   =>  "NA"          ,
    };

    public static void _160_test_when_guard() {

        _99_mealCreate();

        foreach (var food in mealSampleC.foods) {
            Console.WriteLine($"[{food.FoodId,+2}] {food.FoodName,-20} : {food.FoodTime,2} ({FoodTimeCheckTop5(food)})");
        }

    }


}


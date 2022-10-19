
//========================================================================
//
//  Author: 9Health
//
//  Changelog:
//
//    2022/Oct/12  v0.1    Newly create
//    2022/Oct/17  v0.2    Add Action delegate test
//                 v0.2.1  Add multicast Action delegate test
//                 v0.3    Add Function delegate test
//    2022/Oct/18  v0.4    Add null delegate test
//    2022/Oct/19  v0.5    Add comparison delegate test
//
//========================================================================

using System.Collections;

delegate void SimpleDelegate(IEnumerable collection);

public partial class _201_samples_class {

    // Try delegate
    public static void _170_test_delegate() {

        _99_mealCreate();

        var sortTimeQuery = 
            from food in mealSampleC.foods
            orderby food.FoodTime descending
            select food.FoodName + " (" + food.FoodTime + ")";

        Console.WriteLine( "================================================" );
        Console.WriteLine( "[Normal] Food time sort:" );
        Console.WriteLine( "" );

        _201_libs.PrintValues( sortTimeQuery );
        _201_libs.PrintValuesJson( sortTimeQuery );

        Console.WriteLine( "================================================" );
        Console.WriteLine( "[Using delegate] Food time sort:" );
        Console.WriteLine( "" );

        SimpleDelegate callPrintValues = new SimpleDelegate( _201_libs.PrintValues     );
        SimpleDelegate callPrintJSON   = new SimpleDelegate( _201_libs.PrintValuesJson );

        callPrintValues( sortTimeQuery );
        callPrintJSON  ( sortTimeQuery );

        Console.WriteLine( "================================================" );
        Console.WriteLine( "[Using delegate arithmetic + ] Food time sort:" );
        Console.WriteLine( "" );

        SimpleDelegate callAll = callPrintValues + callPrintJSON;

        callAll ( sortTimeQuery );

    }

    // Try Action

    public static void _180_test_action_delegate() {

         Action<IEnumerable> MealDisplayJson;

        _99_mealCreate();

        var sortTimeQuery =
            from food in mealSampleC.foods
            orderby food.FoodTime descending
            select food.FoodName + " (" + food.FoodTime + ")";

        Console.WriteLine( "================================================" );
        Console.WriteLine( "[Normal] Food time sort:" );
        Console.WriteLine( "" );

        _201_libs.PrintValuesJson( sortTimeQuery );

        Console.WriteLine( "================================================" );
        Console.WriteLine( "[Using Action] Food time sort:" );
        Console.WriteLine( "" );

        MealDisplayJson = ie =>_201_libs.PrintValuesJson(ie) ;

        MealDisplayJson( sortTimeQuery );

        Console.WriteLine( "================================================" );
        Console.WriteLine( "[Using Action 2] Food time sort:" );
        Console.WriteLine( "" );

        MealDisplayJson = delegate (IEnumerable ie) { _201_libs.PrintValuesJson(ie); };

        MealDisplayJson( sortTimeQuery );

    }

    // Try Action Multicast

    public static void _181_test_m_action_delegate() {

         Action<IEnumerable> MealDisplay;
         Action<IEnumerable> MealDisplayJson;
         Action<IEnumerable> MealDisplayAll;

        _99_mealCreate();

        var sortTimeQuery =
            from food in mealSampleC.foods
            orderby food.FoodTime descending
            select food.FoodName + " (" + food.FoodTime + ")";

        Console.WriteLine( "================================================" );
        Console.WriteLine( "[Normal] Food time sort:" );
        Console.WriteLine( "" );

        _201_libs.PrintValues    ( sortTimeQuery );
        _201_libs.PrintValuesJson( sortTimeQuery );

        Console.WriteLine( "================================================" );
        Console.WriteLine( "[Using Action] Food time sort:" );
        Console.WriteLine( "" );

        MealDisplay     = ie =>_201_libs.PrintValues    (ie) ;
        MealDisplayJson = ie =>_201_libs.PrintValuesJson(ie) ;

        MealDisplay    ( sortTimeQuery );
        MealDisplayJson( sortTimeQuery );

        Console.WriteLine( "================================================" );
        Console.WriteLine( "[Using Action 2] Food time sort:" );
        Console.WriteLine( "" );

        MealDisplay     = delegate (IEnumerable ie) { _201_libs.PrintValues    (ie); };
        MealDisplayJson = delegate (IEnumerable ie) { _201_libs.PrintValuesJson(ie); };

        MealDisplay    ( sortTimeQuery );
        MealDisplayJson( sortTimeQuery );

        Console.WriteLine( "================================================" );
        Console.WriteLine( "[Using multicast Action] Food time sort:" );
        Console.WriteLine( "" );

        MealDisplayAll = MealDisplay + MealDisplayJson;

        MealDisplayAll( sortTimeQuery );

    }

    // Try Func delegate
    public static void _190_test_func_delegate() {

        Func<NHFoodVerC, bool> isFoodTimeLong; 

        _99_mealCreate();

        isFoodTimeLong = foodVerC => foodVerC is { FoodTime: >= 15 };

        Console.WriteLine("[FoodID] FoodName : IsFoodTimeLongFunc()");

        foreach (var food in mealSampleC.foods) {
            Console.WriteLine($"[{food.FoodId,+2}] {food.FoodName,-20} : {food.FoodTime,2} ({IsFoodTimeLong(food)})");
        }
    }

    // Try null delegate testcase
    // References: https://learn.microsoft.com/en-us/dotnet/csharp/delegates-patterns#handle-null-delegates

    public static void _200_test_null_delegate() {

         Action<IEnumerable> MealDisplay;
         Action<IEnumerable> MealDisplayJson;
         Action<IEnumerable> MealDisplayAll;

        _99_mealCreate();

        var sortTimeQuery =
            from food in mealSampleC.foods
            orderby food.FoodTime descending
            select food.FoodName + " (" + food.FoodTime + ")";

        Console.WriteLine( "================================================" );
        Console.WriteLine( "[Normal] Food time sort:" );
        Console.WriteLine( "" );

        _201_libs.PrintValues    ( sortTimeQuery );
        _201_libs.PrintValuesJson( sortTimeQuery );

        Console.WriteLine( "================================================" );
        Console.WriteLine( "[Using Action 2] Food time sort:" );
        Console.WriteLine( "" );

        MealDisplay     = delegate (IEnumerable ie) { _201_libs.PrintValues    (ie); };
        MealDisplayJson = delegate (IEnumerable ie) { _201_libs.PrintValuesJson(ie); };

        MealDisplay      ( sortTimeQuery );
        MealDisplayJson  ( sortTimeQuery );

        Console.WriteLine( "================================================" );
        Console.WriteLine( "[Using multicast Action] Food time sort:" );
        Console.WriteLine( "" );

        var rand = new Random();
        var randDouble = rand.NextDouble();

        Console.WriteLine( $"[INFO] randDouble = {randDouble}" );
        Console.WriteLine( "" );

        if ( randDouble >= 0.5 ) {
            MealDisplayAll  = MealDisplay      ;
            MealDisplayAll += MealDisplayJson  ;
        } else {
            MealDisplayAll  = null  ;
        }

        Console.WriteLine( "[INFO] Use null conditional operator? to continue silently" );
        Console.WriteLine( "" );

        MealDisplayAll ?. Invoke ( sortTimeQuery );

        Console.WriteLine( "" );
        Console.WriteLine( "[INFO] Try to catch an exception" );
        Console.WriteLine( "" );

        try {
            MealDisplayAll ( sortTimeQuery );
        }
        catch (Exception e) {
            Console.WriteLine($"  [EXCP] Exception happened. e.GetType() = {e.GetType()}");
        }

    }

    // Try comparison delegate
    // References: https://learn.microsoft.com/dotnet/csharp/delegate-class

    private static int compareByLength(NHFoodVerC left, NHFoodVerC right) =>
        left.FoodName.Length.CompareTo(right.FoodName.Length);

    public static void _210_test_comp_delegate() {

        _99_mealCreate();

        Console.WriteLine( "================================================" );
        Console.WriteLine( "[Normal] Food time sort:" );

        _201_libs.PrintValuesJson( mealSampleC.foods );

        Console.WriteLine( "================================================" );
        Console.WriteLine( "[1st try] Food name's length sort:" );

        mealSampleC.foods.Sort( compareByLength );

        _201_libs.PrintValuesJson( mealSampleC.foods );

        Console.WriteLine( "================================================" );
        Console.WriteLine( "[2nd try] Food name's length sort:" );

        mealSampleC.foods.Sort( (left, right) => left.FoodName.Length.CompareTo(right.FoodName.Length) );

        _201_libs.PrintValuesJson( mealSampleC.foods );

        Console.WriteLine( "================================================" );
        Console.WriteLine( "[3rd try] Food name's length sort:" );

        Comparison<NHFoodVerC> comparer = (left, right) => left.FoodName.Length.CompareTo(right.FoodName.Length) ;
        mealSampleC.foods.Sort( comparer );

        _201_libs.PrintValuesJson( mealSampleC.foods );

    }

}


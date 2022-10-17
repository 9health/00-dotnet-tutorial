
//========================================================================
//
//  Author: 9Health
//
//  Changelog:
//
//    2022/Oct/12  v0.1    Newly create
//    2022/Oct/17  v0.2    Add Action delegate test
//                 v0.2.1  Add multicast Action delegate test
//                 v0.3.0  Add Function delegate test
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

}


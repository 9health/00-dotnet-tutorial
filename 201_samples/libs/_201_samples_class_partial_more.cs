
//========================================================================
//
//  Author: 9Health
//
//  Changelog:
//
//    2022/Oct/12  v0.1    Newly create
//    2022/Oct/17  v0.2    Add Action delegate test
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

}


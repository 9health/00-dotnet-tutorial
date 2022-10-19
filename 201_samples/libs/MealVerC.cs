
//========================================================================
//
//  Author: 9Health
//
//  Changelog:
//
//    2022/Sep/14  v0.1    Newly create
//    2022/Oct/19  v0.2    Add food number limitation
//                         Add MealEventArgs
//
//========================================================================

using System.Collections;

public class MealVerC : IEnumerable {

    // Properties
    private  int  foodLimit ;

    public   event EventHandler<MealEventArgs> LimitReached ;

    // Members
    public List<NHFoodVerC> foods = new List<NHFoodVerC>();

    // Constructor
    public MealVerC () {
        foodLimit = 20;
    }

    // Public methods
    public void AddFood(int foodID, string foodName, int foodTime) {

        foods.Add(new NHFoodVerC { FoodId = foodID, FoodName = foodName, FoodTime = foodTime } );

        if ( foods.Count >= foodLimit ) {

            MealEventArgs args = new MealEventArgs() ;

            args.FoodLimit   = foodLimit    ;
            args.TimeReached = DateTime.Now ;

            // Raise limit reached event
            // Continue even when there is no event is attached (subscribed)
            LimitReached ?. Invoke(this, args);
        }
    }

    public IEnumerator GetEnumerator() {
        foreach( var food in foods ) {
            yield return food.FoodName;
        }
    }

    // Public members
    public IEnumerable FoodTimeQuick {
        get { return FoodTimeType(1, 5); }
    }

    public IEnumerable FoodTimeMedium {
        get { return FoodTimeType(5, 15); }
    }

    public IEnumerable FoodTimeLong {
        get { return FoodTimeType(15, 60); }
    }

 // public IEnumerable<NHFoodVerC> TopN(int n) {
 //     for ( var index=0; index<n; index++ ) {
 //         yield return foods[index];
 //     }
 // }

    public IEnumerable TopN(int n) {
        for ( var index=0; index<n; index++ ) {
            yield return "[" + foods[index].FoodId + "] " + foods[index].FoodName;
        }
    }

    public IEnumerable PageN(int n) {
        var stopIndex  = n*3;
        var startIndex = stopIndex-3;
        for ( var index=startIndex; index<stopIndex; index++ ) {
            yield return "[" + foods[index].FoodId + "] " + foods[index].FoodName;
        }
    }

    // Private methods
    private IEnumerable FoodTimeType(int minTime, int maxTime) {
        foreach ( var food in foods ) {
            if ( (food.FoodTime > minTime) && (food.FoodTime <= maxTime) ) {
                yield return food.FoodName +  " (" + food.FoodTime + ")";
            }
        }
    }

}

public class MealEventArgs : EventArgs {

    public  int      FoodLimit   { get; set; }
    public  DateTime TimeReached { get; set; }

}


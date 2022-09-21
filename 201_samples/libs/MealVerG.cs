
using System.Collections;

// [NHFoodVerGAttribute("Hai", "v0.1", false)]
public class MealVerG : IDisposable {

    // Members
    public List<NHFoodVerG> foods = new List<NHFoodVerG>();

    // Private Members
    bool disposed = false;

    // Public methods
    public void AddFood(int foodID, string foodName, int foodTime) {
        foods.Add(new NHFoodVerG { FoodId = foodID, FoodName = foodName, FoodTime = foodTime } );
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

 // public IEnumerable<NHFoodVerG> TopN(int n) {
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

    public void Dispose() {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    // Private methods
    private IEnumerable FoodTimeType(int minTime, int maxTime) {
        foreach ( var food in foods ) {
            if ( (food.FoodTime > minTime) && (food.FoodTime <= maxTime) ) {
                yield return food.FoodName +  " (" + food.FoodTime + ")";
            }
        }
    }

    // Protected methods
    protected virtual void Dispose(bool disposing) {
        if ( disposed )
            return;

     // if ( disposing ) {
     //     foods.Dispose();
     // }

        foreach ( var food in foods ) {
            food.Dispose();
        }

        disposed = true;
    }

}


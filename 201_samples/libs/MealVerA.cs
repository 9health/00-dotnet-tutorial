
using System.Collections;

public class MealVerA : IEnumerable {

    // Private members
    private List<NHFoodVerC> foods = new List<NHFoodVerC>();

    // Public methods
    public void AddFood(int foodID, string foodName, int foodTime) {
        foods.Add(new NHFoodVerC { FoodId = foodID, FoodName = foodName, FoodTime = foodTime } );
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

    // Private methods
    private IEnumerable FoodTimeType(int minTime, int maxTime) {
        foreach ( var food in foods ) {
            if ( (food.FoodTime > minTime) && (food.FoodTime <= maxTime) ) {
                yield return food.FoodName +  " (" + food.FoodTime + ")";
            }
        }
    }

}


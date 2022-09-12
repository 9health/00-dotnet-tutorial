
public class NHFoodVerB {

    // Auto-implemented properties
    public  int  FoodId          { get; set; }
    public  int  FoodTime        { get; set; }
    public  int  FoodSteps       { get; set; }
            int _FoodViewsPrv ;
    public  int  FoodViewsPbl ;                
    public  int  FoodViewsPrvSet { get; private set; }

    public  int  FoodViews       { get; set; }
    public  int  IngredientNum   { get; set; }

    public  int  FoodViewsPrvOK  {
        get =>  _FoodViewsPrv;
        set =>  _FoodViewsPrv = value;
    }

    // Constructor
    public NHFoodVerB() {
        FoodId        = 0      ;
        FoodTime      = 0      ;
        FoodSteps     = 0      ;
        FoodViews     = 0      ;
        IngredientNum = 0      ;
    }

    public NHFoodVerB(int id, int time, int steps, int views, int inum) {
        FoodId        = id     ;
        FoodTime      = time   ;
        FoodSteps     = steps  ;
        FoodViews     = views  ;
        IngredientNum = inum   ;
    }

    // Methods
}


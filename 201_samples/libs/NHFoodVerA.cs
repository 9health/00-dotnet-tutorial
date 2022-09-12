
public class NHFoodVerA {

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
}


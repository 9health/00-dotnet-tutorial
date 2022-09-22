
public class NHFoodVerG {

    // Private Members
    bool disposed = false;

    // Auto-implemented properties
    public  int  FoodId          { get; set; }
    public  int  FoodTime        { get; set; }
    public  int  FoodSteps       { get; set; }

    [NonSerialized()] int _FoodViewsPrv ;
    [NonSerialized()] public  int  FoodViewsPbl ;                
    // Compile error CS0592
    // [NonSerialized()] public  int  FoodViewsPrvSet { get; private set; }

    [NonSerialized()] public  int  FoodViewsPrvSet ;

    public  int  FoodViews       { get; set; }
    public  int  IngredientNum   { get; set; }

    [NonSerialized()] public  int  FoodViewsPrvOK; 
    // public  int  FoodViewsPrvOK  {
    //     get =>  _FoodViewsPrv;
    //     set =>  _FoodViewsPrv = value;
    // }

    public  string FoodName      { get; set; }

    // Constructor
    public NHFoodVerG() {
        FoodId        = 0      ;
        FoodTime      = 0      ;
        FoodSteps     = 0      ;
        FoodViews     = 0      ;
        IngredientNum = 0      ;
    }

    public NHFoodVerG(int id, int time, int steps, int views, int inum) {
        FoodId        = id     ;
        FoodTime      = time   ;
        FoodSteps     = steps  ;
        FoodViews     = views  ;
        IngredientNum = inum   ;
    }

    // Public methods
    public void Dispose() {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    // Protected methods
    protected virtual void Dispose(bool disposing) {
        if ( disposed )
            return;

        if ( disposing ) {
        //  this.Dispose();
        }

        disposed = true;
    }

}


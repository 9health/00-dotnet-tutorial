
using System.ComponentModel.DataAnnotations;

public class NHFoodVerF {

    // Auto-implemented properties
    [Key]
    public  int  FoodId          { get; set; }

    public  int  FoodTime        { get; set; }
    public  int  FoodSteps       { get; set; }

    public  int  FoodViews       { get; set; }
    public  int  IngredientNum   { get; set; }

    public  string FoodName      { get; set; }

}


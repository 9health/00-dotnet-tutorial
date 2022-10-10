
//========================================================================
//
//  Author: 9Health
//
//  Changelog:
//
//    2022/Sep/29  v0.1   Newly create
//    2022/Oct/04  v0.2   Remove FoodId property
//    2022/Oct/07  v0.3   Change foods to FoodList for coding convention
//
//========================================================================

using System.ComponentModel.DataAnnotations;

public class MealVerF {

    [Key]
    public  int  MealId { get; set; }

    // Members
    public List<NHFoodVerF> FoodList { get; } = new ();

    public  string MealName      { get; set; }

}


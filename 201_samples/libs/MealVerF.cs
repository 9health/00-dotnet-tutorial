//========================================================================
//
//  Author: 9Health
//
//  Changelog:
//
//    2022/Sep/29  v0.1   Newly create
//    2022/Oct/04  v0.2   Remove FoodId property
//
//========================================================================

using System.ComponentModel.DataAnnotations;

public class MealVerF {

    [Key]
    public  int  MealId { get; set; }

    // Members
    public List<NHFoodVerF> foods { get; } = new ();

    public  string MealName      { get; set; }

}


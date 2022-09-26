# Description

This describes the food database of this small project.

## Foods table

### Column information

|CID|Name|Type|Not Null|Default Value|Primary Key|
|:-:|----|:--:|:------:|:-----------:|:---------:|
|0|FoodId|INTEGER|1||1|
|1|FoodTime|INTEGER|1||0|
|2|FoodSteps|INTEGER|1||0|
|3|FoodViews|INTEGER|1||0|
|4|IngredientNum|INTEGER|1||0|
|5|FoodName|TEXT|1||0|

|Name         |Description                               |
|-------------|------------------------------------------|
|FoodId       | ID of food                               |
|FoodSteps    | Number of steps to cook this food        |
|FoodViews    | Number of website views for this food    |
|IngredientNum| Number of ingredients to cook this food  |
|FoodName     | Name of this food                        |

### Example

|FoodId|FoodTime|FoodSteps|FoodViews|IngredientNum|FoodName|
|:----:|:------:|:-------:|:-------:|:-----------:|--------|
|1|10|4|0|0|Trung ran|
|2|15|0|0|0|Rau cai xao|

## References

*  [[O'Reilly.com] List column information for a table](https://www.oreilly.com/library/view/using-sqlite/9781449394592/re205.html)

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

## Meal table

### Column information

|CID|Name|Type|Not Null|Default Value|Primary Key|
|:-:|----|:--:|:------:|:-----------:|:---------:|
|0|MealId|INTEGER|1||1|
|1|FoodId|INTEGER|1||0|
|2|MealName|TEXT|1||0|

|Name         |Description                               |
|-------------|------------------------------------------|
|MealId       | ID of meal                               |
|FoodId       | FoodId references from Foods table    .  |
|MealName     | Name of the meal                         |

#### Foreign key attributes

|Id|Sql|Table|From|To|On Update|On Delete|Match Text|
|--|:-:|-----|----|--|:-------:|:-------:|:--------:|
|||Foods|FoodId|FoodId|NO ACTION|NO ACTION|NONE|

### Example

|MealId|FoodId|MealName|
|:----:|:----:|--------|
|1| 1|An sang|
|1|10|An sang|
|1|15|An sang|
|2| 2|An toi|
|2| 4|An toi|
|2|13|An toi|

## References

* [[O'Reilly.com] List column information for a table](https://www.oreilly.com/library/view/using-sqlite/9781449394592/re205.html)
* [[Stack Overflow] How to store a list in a db column](https://stackoverflow.com/questions/444251/how-to-store-a-list-in-a-db-column)
* [[W3Schools] SQL FOREIGN KEY Constraint](https://www.w3schools.com/sql/sql_foreignkey.asp)


//========================================================================
//
//  Author: 9Health
//
//  Changelog:
//
//    2022/Sep/22  v0.1   Newly create
//    2022/Oct/06  v0.2   Add EF refactor testcase
//
//========================================================================

using System.Linq;

public partial class _201_samples_class {

    // Try to update database from command line
    public static void _500_test_ef() {

        using var db = new FoodModel();

        Console.WriteLine( $"Database path: {db.DbPath}" );

        // CRUD trying

        // Create
        Console.WriteLine( "Inserting a new food" );
        db.Add(new NHFoodVerF { FoodName = "Trung ran"   , FoodTime = 10 });
        db.Add(new NHFoodVerF { FoodName = "Rau cai xao" , FoodTime = 15 });
        db.Add(new NHFoodVerF { FoodName = "Thit luoc"   , FoodTime = 20 });
        db.SaveChanges();

        // Read
        Console.WriteLine( "Querying the first food" );
        var firstFoodQuery = db.Foods
                               .OrderBy( f => f.FoodId )
                               .First();

        _201_libs.PrintValuesJson(firstFoodQuery);

        // Update
        Console.WriteLine( "Update a food" );
        firstFoodQuery.FoodSteps = 4;
        db.SaveChanges();

        // _201_libs.EnterAnyInput();

        // Delete
        var lastFoodQuery  = db.Foods
                               .OrderBy( f => f.FoodId )
                               .Last();

        Console.WriteLine( "Delete the last food" );
        db.Remove(lastFoodQuery);
        db.SaveChanges();
    }

    // Try to refactor test case number 500
    public static void _510_test_ef_refactor() {

        using var db = new FoodModel();

        // CRUD trying

        Console.WriteLine( "================================================" );
        Console.WriteLine( "1.Create new foods" );
        db.Add(new NHFoodVerF { FoodName = "Trung ran"   , FoodTime = 10 });
        db.Add(new NHFoodVerF { FoodName = "Rau cai xao" , FoodTime = 15 });
        db.Add(new NHFoodVerF { FoodName = "Thit luoc"   , FoodTime = 20 });
        db.SaveChanges();

        Console.WriteLine( "================================================" );
        Console.WriteLine( "2. Read from the database" );
        _201_libs.PrintDatabaseJSON();

        Console.WriteLine( "================================================" );
        Console.WriteLine( "3. Update database" );
        Console.WriteLine( "     Change FoodSteps to 4" );

        var firstFoodQuery = db.Foods
                               .OrderBy( f => f.FoodId )
                               .First();
        firstFoodQuery.FoodSteps = 4;
        db.SaveChanges();

        _201_libs.PrintDatabaseJSON();

        Console.WriteLine( "================================================" );
        Console.WriteLine( "4. Delete last food from database" );

        var lastFoodQuery  = db.Foods
                               .OrderBy( f => f.FoodId )
                               .Last();
        db.Remove(lastFoodQuery);
        db.SaveChanges();

        _201_libs.PrintDatabaseJSON();
    }

}


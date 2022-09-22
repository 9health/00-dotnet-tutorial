
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

        // Delete
        Console.WriteLine( "Delete the first food" );
        db.Remove(firstFoodQuery);
        db.SaveChanges();
    }

}


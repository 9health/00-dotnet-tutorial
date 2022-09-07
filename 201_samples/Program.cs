
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 201 Samples at here

// _201_samples._01_test_nullable();
_201_samples._02_test_nullable_exception();

public class _201_samples {

    // Test nullable type int?
    public static void _01_test_nullable() {

        int  food_id;
        int? food_id_x;

        food_id = 4;
        Console.WriteLine($"food_id = {food_id}. Expect food_id = 4");

        food_id_x = null;
        Console.WriteLine($"food_id_x = {food_id_x}. Expect food_id_x = (null)");

    }

    // Try exception if null is assigned to int
    // New idea is using random to trick the compiler!!!
    public static void _02_test_nullable_exception() {

        var  rand = new Random();
        var  randDouble = rand.NextDouble();

        int? ingredient_id_db;
        int  ingredient_id_get;


        for ( int i=0; i<4; ++i ) {
            randDouble = rand.NextDouble();
            ingredient_id_db = ( randDouble >= 0.5) ? null : (int)(randDouble*100);

            // 2022/Sep/06: Build failed.
            // 2022/Sep/07: Exception generated at runtime!
            try {
               ingredient_id_get = (int)ingredient_id_db;
               Console.WriteLine($"ingredient_id_get = {ingredient_id_get}. Expect ingredient_id_get = ");
            }
            catch (Exception e) {
                Console.WriteLine($"Exception happened. e.GetType() = {e.GetType()}");
            }
        }


    }

}


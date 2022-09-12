
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

    // Try arrays
    public static void _10_test_array() {
        int[] food_time_A;

        food_time_A = new int[] {10, 20, 30, 40};

        _201_libs.PrintValues(food_time_A);

        int[] food_time_B = new int[] {10, 20, 30, 40, 50};
        food_time_B[0] = 10;
        food_time_B[1] = 10;
        food_time_B[2] = 10;
        food_time_B[3] = 10;
        food_time_B[4] = 10;

        _201_libs.PrintValues(food_time_B);

        int[] food_time_C = new int[7] {10, 20, 30, 40, 50, 60, 70};

        _201_libs.PrintValues(food_time_C);

        int[] food_time_D = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};

        _201_libs.PrintValues(food_time_D);
    }

    // Try vars
    public static void _11_test_var() {

        var food_name_1 = "Thit bo xao rau cai";

        Console.WriteLine($"food_name_1 = {food_name_1}");
        Console.WriteLine($"food_name_1.GetType() = {food_name_1.GetType()}");

        var ingredient_num = 5;
        Console.WriteLine($"ingredient_num = {ingredient_num}");
        Console.WriteLine($"ingredient_num.GetType() = {ingredient_num.GetType()}");

        // var[] food1_steps = {"1. Rua rau", "2. Thai hanh", "3. Xao"};
        var food1_steps = new[] {"1. Rua rau", "2. Thai hanh", "3. Xao"};
        _201_libs.PrintValues(food1_steps);
        Console.WriteLine($"food1_steps.GetType() = {food1_steps.GetType()}");

        var food1 = new { ID = 1, Name = "Thit bo xao rau cai", Steps = 4  };
        Console.WriteLine($"food1 = {food1}");
        Console.WriteLine($"food1.GetType() = {food1.GetType()}");

        var food2 = new { ID = 2, Name = "Thit bo xao rau cai", Steps = 4  };
        Console.WriteLine($"food2 = {food2}");
        Console.WriteLine($"food2.GetType() = {food2.GetType()}");

        var food_list = new {food1, food2};
        Console.WriteLine($"food_list = {food_list}");
        Console.WriteLine($"food_list.GetType() = {food_list.GetType()}");
    }

    // Try class properties get, set
    public static void _20_test_class_prop() {
        NHFoodVerA food1 = new NHFoodVerA(); 
        NHFoodVerA food2 = new NHFoodVerA(); 
        NHFoodVerA food3 = new NHFoodVerA(); 

        food1.FoodId    = 1;

        // error CS0122: 'NHFoodVerA._FoodViewsPrv' is inaccessible due to its protection levelk
        // food1._FoodViewsPrv = 160;

        food1.FoodViewsPbl = 160;

        Console.WriteLine($"food1.FoodViewsPbl = {food1.FoodViewsPbl}");

        // error CS0272: The property or indexer 'NHFoodVerA.FoodViewsPrvSet' cannot be used in this context because the set accessor is inaccessible
        // food1.FoodViewsPrvSet = 160;

        food1.FoodViewsPrvOK = 160;
        Console.WriteLine($"food1.FoodViewsPrvOK = {food1.FoodViewsPrvOK}");
    }

    // Try list simple
    public static void _30_test_list() {

        var food_views_list = new List<int> { 1000, 100, 50, 500000, 1, 2, 3 };

        _201_libs.PrintValues(food_views_list);

        food_views_list.Sort();

        _201_libs.PrintValues(food_views_list);

    }
}

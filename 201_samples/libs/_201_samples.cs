
using System.Diagnostics;
using System.Text.Json;

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

    // Try list with class 
    public static void _31_test_list_class() {

        var foodList = new List<NHFoodVerB>();

        // id, time, steps, views, num
        var food1 = new NHFoodVerB (1, 15, 4, 1,  5);
        var food2 = new NHFoodVerB (2, 15, 4, 10, 5);
        var food3 = new NHFoodVerB (3, 15, 4, 5,  5);

        foodList.Add(food1);
        _201_libs.PrintValues(foodList);

        foodList.Add(food2);
        _201_libs.PrintValues(foodList);

        foodList.Add(food3);
        _201_libs.PrintValues(foodList);

    }

    // Try iterators
    public static void _40_test_iterators() {
        var myMeal = new MealVerA();

        myMeal.AddFood( 1, "Trung ran"  , 10 ) ;
        myMeal.AddFood( 2, "Rau cai xao", 15 ) ;
        myMeal.AddFood( 3, "Thit luoc"  , 20 ) ;
        myMeal.AddFood( 4, "Nuoc mam"   , 4  ) ;

        _201_libs.PrintValues(myMeal);

        Console.WriteLine("FoodTimeQuick:");
        _201_libs.PrintValues(myMeal.FoodTimeQuick);

        Console.WriteLine("FoodTimeLong:");
        _201_libs.PrintValues(myMeal.FoodTimeLong);

        Console.WriteLine("FoodTimeMedium:");
        _201_libs.PrintValues(myMeal.FoodTimeMedium);
    }

    // Try iterators with page
    public static void _41_test_iterators_page() {

        var myMeal = new MealVerB();

        myMeal.AddFood( 1, "Trung ran"       , 10 ) ;
        myMeal.AddFood( 2, "Rau cai xao"     , 15 ) ;
        myMeal.AddFood( 3, "Thit luoc"       , 20 ) ;
        myMeal.AddFood( 4, "Nuoc mam"        , 4  ) ;
        myMeal.AddFood( 5, "Rau muong luoc"  , 20 ) ;
        myMeal.AddFood( 6, "Dau phu luoc"    , 5  ) ;
        myMeal.AddFood( 7, "Nem ran"         , 60 ) ;
        myMeal.AddFood( 8, "Cha cuon la lot" , 30 ) ;
        myMeal.AddFood( 9, "Thanh long"      , 10 ) ;
        myMeal.AddFood(10, "Banh kem"        , 40 ) ;

        Console.WriteLine("Top 3:");
        _201_libs.PrintValues(myMeal.TopN(3));

        Console.WriteLine("Top 4:");
        _201_libs.PrintValues(myMeal.TopN(4));

        Console.WriteLine("Page 1:");
        _201_libs.PrintValues(myMeal.PageN(1));

        Console.WriteLine("Page 2:");
        _201_libs.PrintValues(myMeal.PageN(2));

        Console.WriteLine("Page 3:");
        _201_libs.PrintValues(myMeal.PageN(3));

    }

    // Try simple LINQ
    public static void _50_test_linq() {
        var foodSteps = new int[] { 5, 7, 3, 1, 2 };

        var sortQuery = 
            from steps in foodSteps
            orderby steps
            select steps;

        // Using query expression syntax
        Console.WriteLine("Food steps sort:");
        _201_libs.PrintValues(sortQuery);

        var sortQuery2 = foodSteps.OrderBy(steps => steps);

        // Using method-based query syntax
        Console.WriteLine("Food steps sort using method:");
        _201_libs.PrintValues(sortQuery);
    }

    private static MealVerC mealSampleC;

    // Create a private sample meal
    private static void _99_mealCreate() {

        mealSampleC = new MealVerC();

        mealSampleC.AddFood( 1, "Trung ran"       , 10 ) ;
        mealSampleC.AddFood( 2, "Rau cai xao"     , 15 ) ;
        mealSampleC.AddFood( 3, "Thit luoc"       , 20 ) ;
        mealSampleC.AddFood( 4, "Nuoc mam"        , 4  ) ;
        mealSampleC.AddFood( 5, "Rau muong luoc"  , 20 ) ;
        mealSampleC.AddFood( 6, "Dau phu luoc"    , 5  ) ;
        mealSampleC.AddFood( 7, "Nem ran"         , 60 ) ;
        mealSampleC.AddFood( 8, "Cha cuon la lot" , 30 ) ;
        mealSampleC.AddFood( 9, "Thanh long"      , 10 ) ;
        mealSampleC.AddFood(10, "Banh kem"        , 40 ) ;

    }

    // Try LINQ with class
    public static void _51_test_linq_class() {

        _99_mealCreate();

        var sortTimeQuery = 
            from food in mealSampleC.foods
            orderby food.FoodTime descending
            select food.FoodName + " (" + food.FoodTime + ")";

        //  select new { food.FoodName, food.FoodTime };


        Console.WriteLine("Food time sort:");
        _201_libs.PrintValues(sortTimeQuery);

    }

    // Try asynchronous programming or
    // non-blocking programming!!!
    public async static void _98_download_url_1() {
        Console.WriteLine("Download URL 1");
        await Task.Delay(3000);
    }

    public async static void _98_download_url_2() {
        Console.WriteLine("Download URL 2");
        await Task.Delay(3000);
    }

    public static void _60_test_async_non_blocking() {

        Console.WriteLine("Start");

        var stopwatch = Stopwatch.StartNew();

        _98_download_url_1();
        _98_download_url_2();

        stopwatch.Stop();

        Console.WriteLine($"Elapsed time: {stopwatch.Elapsed}");

    }

    // Try synchronous programming
    public static void _97_download_url_1() {
        Console.WriteLine("Download URL 1");
        Task.Delay(3000).Wait();
    }

    public static void _97_download_url_2() {
        Console.WriteLine("Download URL 2");
        Task.Delay(3000).Wait();
    }

    public static void _61_test_async_blocking() {

        Console.WriteLine("Start");

        var stopwatch = Stopwatch.StartNew();

        _97_download_url_1();
        _97_download_url_2();

        stopwatch.Stop();

        Console.WriteLine($"Elapsed time: {stopwatch.Elapsed}");

    }

    // Try JSON
    public static void _70_test_json() {

        _99_mealCreate();

        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(mealSampleC.foods, options);

        Console.WriteLine($"{jsonString}");

    }

    // Try JSON deserialize
    public static void _71_test_json_deserialize() {

        string jsonString =
        @"{
            ""FoodId"": 10,
            ""FoodTime"": 40,
            ""FoodSteps"": 0,
            ""FoodViewsPrvSet"": 0,
            ""FoodViews"": 0,
            ""IngredientNum"": 0,
            ""FoodViewsPrvOK"": 0,
            ""FoodName"": ""Banh kem""
        }";

        NHFoodVerC? food = JsonSerializer.Deserialize<NHFoodVerC>(jsonString);

        Console.WriteLine($"[{food.FoodId}] {food.FoodName}");
    }

    // Try read characters from terminal
    public static void _80_test_cmd_read() {
        var line = "";
        Console.WriteLine("Enter 'q' to exit.");
        while ( line != "q" ) {
            line = Console.ReadLine();
            Console.WriteLine($"[{DateTime.Now}] Input: {line}");
        }
    }

}


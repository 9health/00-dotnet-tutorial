
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 201 Samples at here

// _201_samples._01_test_nullable();
// _201_samples._02_test_nullable_exception();

// _201_samples._10_test_array();
// _201_samples._11_test_var();
// _201_samples._20_test_class_prop();
// _201_samples._30_test_list();
// _201_samples._31_test_list_class();
// _201_samples._40_test_iterators();
// _201_samples._41_test_iterators_page();
// _201_samples._50_test_linq();
// _201_samples._51_test_linq_class();
// _201_samples._60_test_async_non_blocking();
// _201_samples._61_test_async_blocking();
// _201_samples._70_test_json();
// _201_samples._71_test_json_deserialize();
// _201_samples._80_test_cmd_read();


if ( args.Length == 0 ) {
    InteractiveProcess();
} else {
    var testNumber = args[0];
    Console.WriteLine( $"[{DateTime.Now}] Test number: {testNumber}" );
    InteractiveProcessCore(testNumber);
}


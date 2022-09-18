
partial class Program {

    public static Dictionary<string, string> numberToString = new Dictionary<string, string> {
        {   "1"  , "  [1]  Test nullable"                },
        {   "2"  , "  [2]  Test nullable exception"      },
        {  "10"  , " [10]  Test array"                   },
        {  "11"  , " [11]  Test var"                     },
        {  "20"  , " [20]  Test class prop"              },
        {  "30"  , " [30]  Test list"                    },
        {  "31"  , " [31]  Test list class"              },
        {  "40"  , " [40]  Test iterators"               },
        {  "41"  , " [41]  Test iterators page"          },
        {  "50"  , " [50]  Test LINQ"                    },
        {  "51"  , " [51]  Test LINQ class"              },
        {  "60"  , " [60]  Test async non blocking"      },
        {  "61"  , " [61]  Test async blocking"          },
        {  "70"  , " [70]  Test JSON"                    },
        {  "71"  , " [71]  Test JSON deserialize"        },
        {  "80"  , " [80]  Test cmd read"                },
        {  "90"  , " [90]  Test named arguments"         },
        { "100"  , "[100]  Test preprocesor directives"  },
        { "110"  , "[110]  Test attributes"              },
    };

    public static void InteractiveProcess() {
        Console.WriteLine("Test List");
        Console.WriteLine("   [Test Number] [Test Description]");
        Console.WriteLine("   Please enter 'q' to exit.");
        Console.WriteLine("");

        foreach ( var testDescription in numberToString.Values ) {
            Console.WriteLine( testDescription );
        }

        Console.Write("Please enter a test number: ");

        var testNumber = "";

        while ( testNumber != "q" ) {
            testNumber = Console.ReadLine();
            Console.WriteLine( $"[{DateTime.Now}] Test number: {testNumber}" );

            Console.WriteLine( "" );

            InteractiveProcessCore(testNumber);

            Console.WriteLine( "" );

            foreach ( var testDescription in numberToString.Values ) {
                Console.WriteLine( testDescription );
            }

            Console.WriteLine( "" );
            Console.Write("Please enter a test number: ");
        }
    }

    public static void  InteractiveProcessCore(string testNumber) {
        switch ( testNumber ) {
            case   "1" : _201_samples._01_test_nullable()           ; break;
            case   "2" : _201_samples._02_test_nullable_exception() ; break;
            case  "10" : _201_samples._10_test_array()              ; break;
            case  "11" : _201_samples._11_test_var()                ; break;
            case  "20" : _201_samples._20_test_class_prop()         ; break;
            case  "30" : _201_samples._30_test_list()               ; break;
            case  "31" : _201_samples._31_test_list_class()         ; break;
            case  "40" : _201_samples._40_test_iterators()          ; break;
            case  "41" : _201_samples._41_test_iterators_page()     ; break;
            case  "50" : _201_samples._50_test_linq()               ; break;
            case  "51" : _201_samples._51_test_linq_class()         ; break;
            case  "60" : _201_samples._60_test_async_non_blocking() ; break;
            case  "61" : _201_samples._61_test_async_blocking()     ; break;
            case  "70" : _201_samples._70_test_json()               ; break;
            case  "71" : _201_samples._71_test_json_deserialize()   ; break;
            case  "80" : _201_samples._80_test_cmd_read()           ; break;
            case  "90" : _201_samples._90_test_named_arguments()    ; break;
            case "100" : _201_samples._100_test_prep_directives()   ; break;
            case "110" : _201_samples._110_test_attributes()        ; break;
            case  "q"  :                                            ; break;
            default  : Console.WriteLine("*** Invalid test numer ***"); break;
        }
    }

}

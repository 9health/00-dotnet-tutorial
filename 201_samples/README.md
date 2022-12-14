# Description

This code aims to study and test new features in C# which are

- Nullable value types
- Array
- Implicitly typed local variable (`var`)
- Class
- List
- Iterators
- LINQ
- Asynchronous programming (`async`, `await`)
- JSON library
- Read from cmd
- Named arguments
- Preprocessor directives
- Attributes
- Test expression body definition
- Test `using` statement
- Test `switch` expression
- Test `is` operator, `not` pattern, `and` pattern
- Test `when` case guard
- Test `delegate`
- Test `delegate` argument
- Test `Action` delegate
- Test multicast `Action` delegate
- Test `Func` delegate
- Test `null` delegate
- Test comparison delegate
- Test `event` handler delegate
- Test EF Core
- Test EF Core (Refactor)
- Test EF Core Migration

# Preparation

Download and install .NET 6.0 Runtime for Windows 64-bit at this link

https://aka.ms/dotnet-core-applaunch?missing_runtime=true&arch=x64&rid=win10-x64&apphost_version=6.0.8

# Instruction

- Download the .zip release file and extract it
```
unzip 201_samples_v*.zip
```

- Go to inside the folder
```
cd win-x64
cd win-x64\publish   // From version v0.2
```

- Run the programm
```
201_samples.exe
```

# Sample Output
```
Hello, World!
Test List
   [Test Number] [Test Description]
   Please enter 'q' to exit.

  [1]  Test nullable
  [2]  Test nullable exception
 [10]  Test array
 [11]  Test var
 [20]  Test class prop
 [30]  Test list
 [31]  Test list class
 [40]  Test iterators
 [41]  Test iterators page
 [50]  Test LINQ
 [51]  Test LINQ class
 [60]  Test async non blocking
 [61]  Test async blocking
 [70]  Test JSON
 [71]  Test JSON deserialize
 [80]  Test cmd read
 [90]  Test named arguments
[100]  Test preprocesor directives
[110]  Test attributes
[111]  Test attributes get
[120]  Test exppression body def.
[130]  Test using statement
[140]  Test switch expression
[150]  Test is operator
[160]  Test when case guard
[170]  Test delegate
[171]  Test delegate argument
[180]  Test Action delegate
[181]  Test multicast Action delegate
[190]  Test Func delegate
[200]  Test null delegate
[210]  Test comparison delegate
[220]  Test event handler delegate
[500]  Test EF Core
[510]  Test EF Core (Refactor)
[520]  Test EF Core Migration

* Please enter 'q' to exit.
* Please enter 'l' to list testcases.

Please enter your option:
```

# How to Run
Clone this repository
```
git clone https://github.com/9health/00-dotnet-tutorial.git
```

Change directory to 201_samples
```
cd 201_samples
```

Compile the project (should be used before running in a large project)
```
dotnet build
```

Run the project
```
dotnet run
```

Release _framework-dependent_ binary files (output in `publish` folder)
```
dotnet publish --self-contained false -c Release -p:PublishSingleFile=true -r win-x64
```

Clean built files
```
dotnet clean
```

Build project (should be used when modifying files in a large project!)
```
dotnet build
```

Run a specific test from the command line.
```
dotnet run -- [testNumber]
```

Example to run test 70
```
dotnet run -- 70
```

# For EF Core
References

https://learn.microsoft.com/ef/core/get-started/overview/first-app

Install EF Core packages (optional)
```
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
```

Create migration files
```
dotnet ef migrations add [migrationName]
```

Generate SQL migration script (to review)
```
dotnet ef migration script
```

Create database (or apply changes to the database)
```
dotnet ef database update
dotnet ef database update -v // For more details
```

# For SQLite3
List databases
```
.databases
```

List tables
```
.tables
```

Show column names
```
PRAGMA table_info(table_name);
```

List all foods
```
SELECT * FROM foods;
```

One-line command
```
sqlite3 -init list_food.sql food.db .quit
```

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

[ 1]  Test nullable
[ 2]  Test nullable exception
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
Please enter a test number:
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

Run the project
```
dotnet run
```

Release _framework-dependent_ binary files
```
dotnet publish --self-contained false -r win-x64
```
# dotnet-tutorial
A .NET tutorial

# References

[[microsoft.com] .NET Tutorial - Hello World in 5 minutes](https://dotnet.microsoft.com/en-us/learn/dotnet/hello-world-tutorial/intro)

# Preparations

- Windows 10
- .NET 6.0
- [Git Client](https://git-scm.com/downloads) 

# How to run

```
cd MyApp
dotnet run
```

# Expected output
```
Hello, World!
The current time is 9/2/2022 4:37:58 AM
Sum from 1 to 10 is 55
```

# Other Notes

## Temporary files

**It shoule be excluded before commiting to Git repository!**

```
$ find obj/ bin/
obj/
obj/Debug
obj/Debug/net6.0
obj/Debug/net6.0/.NETCoreApp,Version=v6.0.AssemblyAttributes.cs
obj/Debug/net6.0/apphost.exe
obj/Debug/net6.0/MyApp.AssemblyInfo.cs
obj/Debug/net6.0/MyApp.AssemblyInfoInputs.cache
obj/Debug/net6.0/MyApp.assets.cache
obj/Debug/net6.0/MyApp.csproj.AssemblyReference.cache
obj/Debug/net6.0/MyApp.csproj.CoreCompileInputs.cache
obj/Debug/net6.0/MyApp.csproj.FileListAbsolute.txt
obj/Debug/net6.0/MyApp.dll
obj/Debug/net6.0/MyApp.GeneratedMSBuildEditorConfig.editorconfig
obj/Debug/net6.0/MyApp.genruntimeconfig.cache
obj/Debug/net6.0/MyApp.GlobalUsings.g.cs
obj/Debug/net6.0/MyApp.pdb
obj/Debug/net6.0/ref
obj/Debug/net6.0/ref/MyApp.dll
obj/Debug/net6.0/refint
obj/Debug/net6.0/refint/MyApp.dll
obj/MyApp.csproj.nuget.dgspec.json
obj/MyApp.csproj.nuget.g.props
obj/MyApp.csproj.nuget.g.targets
obj/project.assets.json
obj/project.nuget.cache
bin/
bin/Debug
bin/Debug/net6.0
bin/Debug/net6.0/MyApp.deps.json
bin/Debug/net6.0/MyApp.dll
bin/Debug/net6.0/MyApp.exe
bin/Debug/net6.0/MyApp.pdb
bin/Debug/net6.0/MyApp.runtimeconfig.json
```

## Main program file

There is no main program in the source code, please refer this [link](https://aka.ms/new-console-template).

## Some commands to try

```
$ dotnet

Usage: dotnet [options]
Usage: dotnet [path-to-application]

Options:
  -h|--help         Display help.
  --info            Display .NET information.
  --list-sdks       Display the installed SDKs.
  --list-runtimes   Display the installed runtimes.

path-to-application:
  The path to an application .dll file to execute.
```

```
$ dotnet --info
.NET SDK (reflecting any global.json):
 Version:   6.0.400
 Commit:    7771abd614

Runtime Environment:
 OS Name:     Windows
 OS Version:  10.0.20348
 OS Platform: Windows
 RID:         win10-x64
 Base Path:   C:\Users\ninehealth\AppData\Local\Microsoft\dotnet\sdk\6.0.400\   

global.json file:
  Not found

Host:
  Version:      6.0.8
  Architecture: x64
  Commit:       55fb7ef977

.NET SDKs installed:
  6.0.400 [C:\Users\ninehealth\AppData\Local\Microsoft\dotnet\sdk]

.NET runtimes installed:
  Microsoft.AspNetCore.App 3.1.28 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
  Microsoft.AspNetCore.App 5.0.17 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
  Microsoft.AspNetCore.App 6.0.8 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
  Microsoft.AspNetCore.App 6.0.8 [C:\Users\ninehealth\AppData\Local\Microsoft\dotnet\shared\Microsoft.AspNetCore.App]
  Microsoft.NETCore.App 3.1.28 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.NETCore.App 5.0.17 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.NETCore.App 6.0.8 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.NETCore.App 6.0.8 [C:\Users\ninehealth\AppData\Local\Microsoft\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.WindowsDesktop.App 6.0.8 [C:\Users\ninehealth\AppData\Local\Microsoft\dotnet\shared\Microsoft.WindowsDesktop.App]

Download .NET:
  https://aka.ms/dotnet-download

Learn about .NET Runtimes and SDKs:
  https://aka.ms/dotnet/runtimes-sdk-info
```

```
$ dotnet --list-runtimes
Microsoft.AspNetCore.App 3.1.28 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
Microsoft.AspNetCore.App 5.0.17 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
Microsoft.AspNetCore.App 6.0.8 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
Microsoft.AspNetCore.App 6.0.8 [C:\Users\ninehealth\AppData\Local\Microsoft\dotnet\shared\Microsoft.AspNetCore.App]
Microsoft.NETCore.App 3.1.28 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
Microsoft.NETCore.App 5.0.17 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
Microsoft.NETCore.App 6.0.8 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
Microsoft.NETCore.App 6.0.8 [C:\Users\ninehealth\AppData\Local\Microsoft\dotnet\shared\Microsoft.NETCore.App]
Microsoft.WindowsDesktop.App 6.0.8 [C:\Users\ninehealth\AppData\Local\Microsoft\dotnet\shared\Microsoft.WindowsDesktop.App]
```

```
$ dotnet new
The 'dotnet new' command creates a .NET project based on a template.

Common templates are:
Template Name         Short Name    Language    Tags               
--------------------  ------------  ----------  -------------------
ASP.NET Core Web App  webapp,razor  [C#]        Web/MVC/Razor Pages
Blazor Server App     blazorserver  [C#]        Web/Blazor         
Class Library         classlib      [C#],F#,VB  Common/Library
Console App           console       [C#],F#,VB  Common/Console
Windows Forms App     winforms      [C#],VB     Common/WinForms
WPF Application       wpf           [C#],VB     Common/WPF

An example would be:
   dotnet new console

Display template options with:
   dotnet new console -h
Display all installed templates with:
   dotnet new --list
Display templates available on NuGet.org with:
   dotnet new web --search
```

```
$ dotnet new --help
Usage: new [options]

Options:
  -h, --help                     Displays help for this command.
  -l, --list <PARTIAL_NAME>      Lists templates containing the specified template name. If no name is specified, lists all templates.
  -n, --name                     The name for the output being created. If no name is specified, the name of the output directory is used.
  -o, --output                   Location to place the generated output.        
  -i, --install                  Installs a source or a template package.       
  -u, --uninstall                Uninstalls a source or a template package.     
  --interactive                  Allows the internal dotnet restore command to stop and wait for user input or action (for example to complete authentication). 
  --add-source, --nuget-source   Specifies a NuGet source to use during install.
  --type                         Filters templates based on available types. Predefined values are "project" and "item".
  --dry-run                      Displays a summary of what would happen if the given command line were run if it would result in a template creation.
  --force                        Forces content to be generated even if it would change existing files. If used together with --install option, allows installing template packages from the specified sources even if they would override a template package from another source.
  -lang, --language              Filters templates based on language and specifies the language of the template to create.
  --update-check                 Check the currently installed template packages for updates.
  --update-apply                 Check the currently installed template packages for update, and install the updates.
  --search <PARTIAL_NAME>        Searches for the templates on NuGet.org.       
  --author <AUTHOR>              Filters the templates based on the template author. Applicable only with --search or --list | -l option.
  --package <PACKAGE>            Filters the templates based on NuGet package ID. Applies to --search.
  --columns <COLUMNS_LIST>       Comma separated list of columns to display in --list and --search output.
                                 The supported columns are: language, tags, author, type.
  --columns-all                  Display all columns in --list and --search output.
  --tag <TAG>                    Filters the templates based on the tag. Applies to --search and --list.
  --no-update-check              Disables checking for the template package updates when instantiating a template.
```

```
$ dotnet new -l -h
These templates matched your input: 

Template Name                                 Short Name           Language    Tags                      
--------------------------------------------  -------------------  ----------  --------------------------
ASP.NET Core Empty                            web                  [C#],F#     Web/Empty                 
ASP.NET Core gRPC Service                     grpc                 [C#]        Web/gRPC                  
ASP.NET Core Web API                          webapi               [C#],F#     Web/WebAPI                
ASP.NET Core Web App                          webapp,razor         [C#]        Web/MVC/Razor Pages       
ASP.NET Core Web App (Model-View-Controller)  mvc                  [C#],F#     Web/MVC                   
ASP.NET Core with Angular                     angular              [C#]        Web/MVC/SPA               
ASP.NET Core with React.js                    react                [C#]        Web/MVC/SPA               
Blazor Server App                             blazorserver         [C#]        Web/Blazor                
Blazor WebAssembly App                        blazorwasm           [C#]        Web/Blazor/WebAssembly/PWA
Class Library                                 classlib             [C#],F#,VB  Common/Library            
Console App                                   console              [C#],F#,VB  Common/Console            
dotnet gitignore file                         gitignore                        Config                    
Dotnet local tool manifest file               tool-manifest                    Config                    
EditorConfig file                             editorconfig                     Config                    
global.json file                              globaljson                       Config
MSTest Test Project                           mstest               [C#],F#,VB  Test/MSTest
MVC ViewImports                               viewimports          [C#]        Web/ASP.NET
MVC ViewStart                                 viewstart            [C#]        Web/ASP.NET
NuGet Config                                  nugetconfig                      Config
NUnit 3 Test Item                             nunit-test           [C#],F#,VB  Test/NUnit
NUnit 3 Test Project                          nunit                [C#],F#,VB  Test/NUnit
Protocol Buffer File                          proto                            Web/gRPC
Razor Class Library                           razorclasslib        [C#]        Web/Razor/Library
Razor Component                               razorcomponent       [C#]        Web/ASP.NET
Razor Page                                    page                 [C#]        Web/ASP.NET               
Solution File                                 sln                              Solution
Web Config                                    webconfig                        Config
Windows Forms App                             winforms             [C#],VB     Common/WinForms
Windows Forms Class Library                   winformslib          [C#],VB     Common/WinForms
Windows Forms Control Library                 winformscontrollib   [C#],VB     Common/WinForms
Worker Service                                worker               [C#],F#     Common/Worker/Web
WPF Application                               wpf                  [C#],VB     Common/WPF
WPF Class Library                             wpflib               [C#],VB     Common/WPF
WPF Custom Control Library                    wpfcustomcontrollib  [C#],VB     Common/WPF
WPF User Control Library                      wpfusercontrollib    [C#],VB     Common/WPF
xUnit Test Project                            xunit                [C#],F#,VB  Test/xUnit
```
```
- The following example creates a .sln file in the specified folder, with the same name as the folder:

$ dotnet new sln --output MySolution

- Create a solution, a console app, and two class libraries. Add the projects to the solution, and use the --solution-folder option of dotnet sln to organize the class libraries into a solution folder.

$ dotnet new sln -n mysolution
$ dotnet new console -o myapp
$ dotnet new classlib -o mylib1
$ dotnet new classlib -o mylib2
$ dotnet sln mysolution.sln add myapp\myapp.csproj
$ dotnet sln mysolution.sln add mylib1\mylib1.csproj --solution-folder mylibs
$ dotnet sln mysolution.sln add mylib2\mylib2.csproj --solution-folder mylibs

-Start Solution in VS : This will open whatever version of Visual Studio you currently have set to open with .sln files in Windows.

$ start MySolution/MySolution.sln and hit Enter.



```

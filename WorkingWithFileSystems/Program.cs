using static System.Console;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;
using tryCsEx;

//OutputFileSystemInfo();
//WorkWithDrives();
//WorkWithDirectories();
WorkWithFiles();

static void OutputFileSystemInfo()
{
    WriteLine("{0,-33} {1}", arg0: "Path.PathSeparator",
      arg1: PathSeparator);
    WriteLine("{0,-33} {1}", arg0: "Path.DirectorySeparatorChar",
      arg1: DirectorySeparatorChar);
    WriteLine("{0,-33} {1}", arg0: "Directory.GetCurrentDirectory()",
      arg1: GetCurrentDirectory());
    WriteLine("{0,-33} {1}", arg0: "Environment.CurrentDirectory",
      arg1: CurrentDirectory);
    WriteLine("{0,-33} {1}", arg0: "Environment.SystemDirectory",
      arg1: SystemDirectory);   
    WriteLine("{0,-33} {1}", arg0: "Path.GetTempPath()",
      arg1: GetTempPath());
    WriteLine("GetFolderPath(SpecialFolder");
    WriteLine("{0,-33} {1}", arg0: " .System)",
      arg1: GetFolderPath(SpecialFolder.System));
    WriteLine("{0,-33} {1}", arg0: " .ApplicationData)",
      arg1: GetFolderPath(SpecialFolder.ApplicationData));
    WriteLine("{0,-33} {1}", arg0: " .MyDocuments)",
      arg1: GetFolderPath(SpecialFolder.MyDocuments));
    WriteLine("{0,-33} {1}", arg0: " .Personal)",
      arg1: GetFolderPath(SpecialFolder.Personal));
}

static void WorkWithDrives()
{
    WriteLine("{0,-30} | {1,-10} | {2,-7} | {3,18} | {4,18}",
      "NAME", "TYPE", "FORMAT", "SIZE (BYTES)", "FREE SPACE");
    foreach(DriveInfo drive in DriveInfo.GetDrives())
    {
        if (drive.IsReady)
        {
            WriteLine(
              "{0,-30} | {1,-10} | {2,-7} | {3,18:N0} | {4,18:N0}",
              drive.Name, drive.DriveType, drive.DriveFormat,
              drive.TotalSize, drive.AvailableFreeSpace);
        }
        else
        {
            WriteLine("{0,-30} | {1,-10}", drive.Name, drive.DriveType);
        }
    }
}

static void WorkWithDirectories()
{
    //Define a custom path under the user's home directory by creating an array of strings for the directory names, and then properly combining them with the Path type's Combine method.
    string newFolder = Combine(GetFolderPath(SpecialFolder.Personal),"Code","Chapter09","NewFolder");
    WriteLine($"Working with: {newFolder}");
    WriteLine($"Existed?: {Exists(newFolder)}");
    if (Exists(newFolder))
    {
        Delete(newFolder, recursive: true);
    }
    else
    {
        CreateDirectory(newFolder);
    }
}

static void WorkWithFiles()
{
    string dir = Combine(GetFolderPath(SpecialFolder.Personal), "Code", "Chapter09", "OutputFiles");
    CreateDirectory(dir);
    string file = Combine(dir, "Dummy.txt");
    string backup = Combine(dir, "Dummy.bak");
    // create a new text file and write a line to it
    StreamWriter text = File.CreateText(file);
    text.WriteLine("Hello C#");
    text.Close(); // close file and release resources
    WriteLine($"Does it exist? {File.Exists(file)}");
    // copy the file, and overwrite if it already exists
    File.Copy(sourceFileName: file, destFileName: backup, overwrite: true);
    WriteLine($"Does {backup} exist? {File.Exists(backup)}");
    Write("Confirm the files exist, and then press ENTER: ");
    ReadLine();
    // delete file
    File.Delete(file);
    WriteLine($"Does it exist? {File.Exists(file)}");
    // read from the text file backup
    WriteLine($"Reading contents of {backup}:");
    // my sol:
    WriteLine(File.ReadAllText(backup));
    StreamReader textReader = File.OpenText(backup);
    WriteLine(textReader.ReadToEnd());
    textReader.Close();

    // Managing paths
    WriteLine($"Folder Name: {GetDirectoryName(file)}");
    WriteLine($"File Name: {GetFileName(file)}");
    WriteLine("File Name without Extension: {0}",
      GetFileNameWithoutExtension(file));
    WriteLine($"File Extension: {GetExtension(file)}");
    WriteLine($"Random File Name: {GetRandomFileName()}");
    WriteLine($"Temporary File Name: {GetTempFileName()}");

    //getting file information
    FileInfo info = new(backup);
    WriteLine($"{backup}:");
    WriteLine($"Contains {info.Length} bytes");
    WriteLine($"Last accessed {info.LastAccessTime}");
    WriteLine($"Has readonly set to {info.IsReadOnly}");

    FileStream aFile = File.Open(backup,FileMode.Open, FileAccess.Read, FileShare.Read);
    aFile.Close();

    FileInfo anInfo = new(backup);
    WriteLine("Is the backup file compressed? {0}",
      anInfo.Attributes.HasFlag(FileAttributes.Compressed));
}

WorkWithText();

static void WorkWithText()
{
    // define a file to write to
    string filePath = Combine(CurrentDirectory,"stream.txt");
    // create a text file and return a helper writer
    StreamWriter streamWriter = File.CreateText(filePath);
    // enumerate the strings, writing each one
    // to the stream on a separate line
    foreach (string item in Viper.Callsigns)
    {
        streamWriter.WriteLine(item);
    }
    streamWriter.Close(); // release resource
    WriteLine("{0} contains {1:N0} bytes.",
    arg0: filePath,
    arg1: new FileInfo(filePath).Length);
    WriteLine(File.ReadAllText(filePath));
}
static class Viper
{
    // define an array of Viper pilot call signs
   public static string[] Callsigns = new[]
      {
        "Husker", "Starbuck", "Apollo", "Boomer",
        "Bulldog", "Athena", "Helo", "Racetrack"
      };
}
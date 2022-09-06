using static System.Console;

string name = "Samatha Jones";
// using substring
int lengthOfFirst = name.IndexOf(' ');
int lengthOfLast = name.Length - lengthOfFirst - 1;
WriteLine($"FirstName: {name.Substring(0, lengthOfFirst)}");
WriteLine($"LastName: {name.Substring(lengthOfFirst, lengthOfLast)}");

//using Span
ReadOnlySpan<char> nameAsSpan = name.AsSpan();
ReadOnlySpan<char> firstNameSpan = nameAsSpan[0..lengthOfFirst];
ReadOnlySpan<char> lastNameSpan = nameAsSpan[^lengthOfLast..^0];
WriteLine("First name: {0}, Last name: {1}",
  arg0: firstNameSpan.ToString(),
  arg1: lastNameSpan.ToString());

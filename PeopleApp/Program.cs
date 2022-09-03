using Packt.Shared;
using static System.Console;

Person harry = new() { Name = "Harry" };
Person mary = new() { Name = "Marry" };
Person jill = new() { Name = "Jill" };

//call instance method
Person baby1 = mary.ProcreateWith(harry);
baby1.Name = "Gary";
//call static method
Person baby2 = Person.Procreate(harry, jill);
// call an operator
Person baby3 = mary * jill;
WriteLine($"{harry.Name} hass {harry.Children.Count} children.");
WriteLine($"{mary.Name} has {mary.Children.Count} child");
WriteLine($"{jill.Name} has {jill.Children.Count} child");
WriteLine(
    format: "{0}'s first child is named \"{1}\".",
    arg0: harry.Name,
    arg1: harry.Children[0].Name);
// local function
WriteLine($"5! is {Person.Factorial(5)}");

//delegate
static void Harry_Shout(object? sender, EventArgs e)
{
    if (sender is null) return;
    Person p = (Person)sender;
    WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
}

harry.Shout += Harry_Shout;

harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();
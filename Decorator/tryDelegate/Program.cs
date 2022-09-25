// See https://aka.ms/new-console-template for more information
using System;

Person harry = new() { Name = "Harry" };
harry.Shout += Harry_Shout;
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();



static void Harry_Shout(object? sender, EventArgs e)
{
    if (sender is null) return;
    Person p = (Person)sender;
    Console.WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
}
public class Person
{
    public string? Name { get; set; }
    public event EventHandler? Shout;
    public int AngerLevel;
    public void Poke()
    {
        AngerLevel++;
        if (AngerLevel >= 3)
        {
            if (Shout != null)
            {
                Shout(this, EventArgs.Empty);
            }
        }
    }
}
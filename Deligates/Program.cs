// See https://aka.ms/new-console-template for more information
using Deligates.Classes;
Console.WriteLine("Application has been started.!!!"); 
SimpleDelTest simpleDel = new SimpleDelTest();
Console.WriteLine("Calling Simple Deligate");
simpleDel.SimapleDeligate("This is Message passed to Simple Deligate");
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("Calling Multi Cast Deligate");
MultiCastDel multiCastDel = new MultiCastDel();
Console.WriteLine("Enter first integer");
string s1 = Console.ReadLine();
Console.WriteLine("Enter second integer");
string s2 = Console.ReadLine();
int x;
int y;
while (!int.TryParse(s1, out x))
{
    Console.WriteLine("Invalid input. Please enter a valid number:");
    s1 = Console.ReadLine();
}
while (!int.TryParse(s2, out y))
{
    Console.WriteLine("Invalid input. Please enter a valid number:");
    s2 = Console.ReadLine();
}
multiCastDel.MultiCastDeligate(x, y);

Console.WriteLine("------------------------------------------------");
Console.WriteLine("Examples for built in deligates\n\nEnter you name");
BuiltInDel builtInDel = new BuiltInDel();
string name = Console.ReadLine();
builtInDel.greet(name);
int chars = builtInDel.stringLength(name);
Console.WriteLine($"Total Charaters in names with Func deligate is {chars}");
Console.WriteLine($"Name length is even : {builtInDel.isEven(chars)}");

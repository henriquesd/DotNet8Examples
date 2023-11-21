using DotNet8;
using MyConsole = System.Console;

MyConsole.WriteLine("Hello .NET 8!");

MyConsole.WriteLine("Test console");

var person = AliasAnyType.GetPerson();
MyConsole.WriteLine(person);

AliasAnyType.PrintPerson(person);
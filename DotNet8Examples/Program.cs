using DotNet8;
using System.Text.Json;
using static DotNet8Examples.PrimaryConstructors;
using MyConsole = System.Console;

Console.WriteLine("Hello .NET 8!");

#region Alias any type

MyConsole.WriteLine("Test console");

var person = AliasAnyType.GetPerson();
Console.WriteLine(person);

AliasAnyType.PrintPerson(person);

#endregion

#region Primary Constructors

var book1 = new BookDefault(1, "The Lord of The Rings the Fellowship of the Ring", new List<decimal>() { 5, 4, 4, 5 });
Console.WriteLine($"{nameof(book1)}: {JsonSerializer.Serialize(book1)}");

var book2 = new Book(2, "The Lord of The Rings the Two Towers", new List<decimal>() { 4, 3, 2, 4 });
book2.Pages = 352;
//book2.Title = "The Lord of The Rings the Return of the King";
Console.WriteLine($"{nameof(book2)}: {JsonSerializer.Serialize(book2)}");

var book3 = new Book(3, "The Lord of the Rings the Return of the King");
Console.WriteLine($"{nameof(book3)}: {JsonSerializer.Serialize(book3)}");

var book4 = new Book();
Console.WriteLine($"{nameof(book4)}: {JsonSerializer.Serialize(book4)}");

#endregion

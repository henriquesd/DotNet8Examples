using DotNet8;
using DotNet8Examples;
using System.Text.Json;
using static DotNet8Examples.PrimaryConstructors;
using MyConsole = System.Console;

Console.WriteLine("Hello .NET 8 and C# 12!");
Console.WriteLine("-------------------------");

#region Alias any type

Console.WriteLine($"Alias any type examples:{Environment.NewLine}");

MyConsole.WriteLine("Test console");

var person = AliasAnyType.GetPerson();
Console.WriteLine(person);

AliasAnyType.PrintPerson(person);

Console.WriteLine("-------------------------");

#endregion

#region Primary Constructors

Console.WriteLine($"Primary Constructors examples:{Environment.NewLine}");

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

Console.WriteLine("-------------------------");

#endregion

#region Collection Expressions

Console.WriteLine($"Collection Expressions examples:{Environment.NewLine}");

var collectionExpressions = new CollectionExpressions();
collectionExpressions.Demo();

Console.WriteLine("-------------------------");

#endregion

#region Default Lambda Parameters

Console.WriteLine($"Default Lambda Parameters examples:{Environment.NewLine}");

var defaultLambdaParameters = new DefaultLambdaParameters();
defaultLambdaParameters.Demo();

Console.WriteLine("-------------------------");

#endregion
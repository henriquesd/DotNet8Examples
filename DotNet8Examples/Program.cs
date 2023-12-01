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
// The line below will make the compiler issue an error;
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

#region Experimental Attribute

Console.WriteLine($"Experimental Attribute examples:{Environment.NewLine}");

#pragma warning disable Test001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
var demo = new ExperimentalAttributeDemo();
#pragma warning restore Test001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

// It's configured on .csproj to ignore the Test002;
demo.Print();

Console.WriteLine("-------------------------");

#endregion

#region Ref Readonly Parameters

Console.WriteLine($"Ref Readonly Parameters examples:{Environment.NewLine}");

var refOnlyParametersDemo = new RefOnlyParameters();

Console.WriteLine("Method with ref readonly:");
var numberExample1 = 1;
refOnlyParametersDemo.PrintWithRefReadonly(ref numberExample1);
Console.WriteLine($"Your number is now {numberExample1}");

Console.WriteLine("Method with in:");
var numberExample2 = 2;
refOnlyParametersDemo.PrintWithIn(numberExample2);
Console.WriteLine($"Your number is now {numberExample2}");

Console.WriteLine("Method with ref:");
var numberExample3 = 3;
refOnlyParametersDemo.PrintWithRef(ref numberExample3);
Console.WriteLine($"Your number is now {numberExample3}");

Console.WriteLine("-------------------------");

#endregion
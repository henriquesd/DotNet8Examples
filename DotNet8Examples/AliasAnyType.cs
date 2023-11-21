using Person = (string name, int age, string country);

namespace DotNet8
{
    public static class AliasAnyType
    {
        public static Person GetPerson()
        {
            Person person = new("Aragorn", 33, "Netherlands");

            return person;
        }

        public static void PrintPerson(Person person)
        {
            Console.WriteLine($"{person.name}, {person.age}, {person.country}");
        }
    }
}
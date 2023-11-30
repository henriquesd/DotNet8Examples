namespace DotNet8Examples
{
    public class RefOnlyParameters
    {
        // Example using "ref" and "readonly" keywords;
        public void PrintWithRefReadonly(ref readonly int number)
        {
            Console.WriteLine($"Your number is {number}");
            //number++; // This will make the compiler issue an error;
        }

        // Example using the "in" keyword;
        public void PrintWithIn(in int number)
        {
            Console.WriteLine($"Your number is {number}");
            //number++; // This will make the compiler issue an error;
        }

        // Example using only the "ref" keyword;
        public void PrintWithRef(ref int number)
        {
            Console.WriteLine($"Your number is {number}");
            number++;
        }
    }
}

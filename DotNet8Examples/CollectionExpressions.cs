using System.Text.Json;

namespace DotNet8Examples
{
    public class CollectionExpressions
    {
        public void Demo()
        {
            #region Default

            // Default Array;
            int[] myArray1 = new int[] { 10, 20, 30, 40, 50 };
            var myArray2 = new int[] { 10, 20, 30, 40, 50 };

            // Default List;
            List<string> myList1 = new List<string> { "apple", "banana", "orange" };
            var myList2 = new List<string> { "apple", "banana", "orange" };

            // Default Span;
            var array3 = new char[] { 'a', 'b', 'c', 'd', 'e' };
            Span<char> mySpan1 = array3.AsSpan();
            var mySpan2 = array3.AsSpan();

            #endregion

            #region Collection Expressions

            // Array with Collection Expressions;
            int[] demoArray = [10, 20, 30, 40, 50];

            // List with Collection Expressions;
            List<string> demoList = ["apple", "banana", "orange"];

            // Span with Collection Expressions;
            Span<char> demoSpan = ['a', 'b', 'c', 'd', 'e'];

            // Jagged 2D Array with Collection Expressions;
            int[][] demoJagged2DArray = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

            // Jagged 2D Array from variables;
            int[] row0 = [1, 2, 3];
            int[] row1 = [4, 5, 6];
            int[] row2 = [7, 8, 9];
            int[][] demoJagged2DDArrayFromVariables = [row0, row1, row2];

            // Array with spread operator;
            int[] demoWithSpreadOperator = [..row0, ..row1, ..row2];

            #endregion

            Console.WriteLine($"{nameof(demoArray)}: {JsonSerializer.Serialize(demoArray)}");
            Console.WriteLine($"{nameof(demoList)}: {JsonSerializer.Serialize(demoList)}");
            Console.Write($"{nameof(demoSpan)}: ");
            foreach (var item in demoSpan) Console.Write($"{item} ");
            Console.WriteLine();

            Console.WriteLine($"{nameof(demoJagged2DArray)}: {JsonSerializer.Serialize(demoJagged2DArray)}");
            Console.WriteLine($"{nameof(demoJagged2DDArrayFromVariables)}: {JsonSerializer.Serialize(demoJagged2DDArrayFromVariables)}");
            Console.WriteLine($"{nameof(demoWithSpreadOperator)}: {JsonSerializer.Serialize(demoWithSpreadOperator)}");
        }
    }
}
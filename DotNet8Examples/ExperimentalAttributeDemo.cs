using System.Diagnostics.CodeAnalysis;

namespace DotNet8Examples
{
    [Experimental(diagnosticId: "Test001")]
    public class ExperimentalAttributeDemo
    {
        [Experimental(diagnosticId: "Test002")]
        public void Print()
        {
            Console.WriteLine("Hello Experimental Attribute");
        }
    }
}
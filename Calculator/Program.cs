using CalculatorLibrary;

namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        int a = 2;
        int b = 3;
        int c = CalculatorLibrary.CalculatorLibrary.Add(a,b);
        Console.WriteLine($"Result from Add({a},{b}) is {c}");
    }
}

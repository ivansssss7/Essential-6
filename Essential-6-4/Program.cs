namespace Essential_6_4;

static class Calculator
{
    public static int Add(int x, int y)
    {
        return x + y;
    }
    public static int Subtract(int x, int y)
    {
        return x - y;
    }
    public static int Multiply(int x, int y)
    {
        return x * y;
    }
    public static int Divide(int x, int y)
    {
        return x / y;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(Calculator.Add(2, 2));//4
        Console.WriteLine(Calculator.Subtract(2, 1));//1
        Console.WriteLine(Calculator.Multiply(2, 3));//6
        Console.WriteLine(Calculator.Divide(9, 3));//3
        Console.ReadLine();
    }
}
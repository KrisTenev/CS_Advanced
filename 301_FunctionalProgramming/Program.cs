

int a = 0;
string x = "sad";

Func<int, long> operation = Square;

operation(2);

PrintResult(5, Square);
PrintResult(5, Factorial);

Action<int> action = PrintToConsoleWithLines;
action += PrintToConsole;
action += PrintToConsole;
action += PrintToConsole;
action += PrintToConsole;
action += PrintToConsole;

action(2);

static void PrintToConsoleWithLines (int x)
{
    Console.WriteLine("============================");
    Console.WriteLine($"PrintToConsoleWithLines {x}");
    Console.WriteLine("============================");
}

static void PrintToConsole(int x)
{
    Console.WriteLine($"PrintToConsole {x}");
}

static void PrintResult(int x, Func<int, long> func)
{
    var result = func(x);
    Console.WriteLine("============================");
    Console.WriteLine($"    Result {result}");
    Console.WriteLine("============================");
}

static long Square(int number)
{
    return number * number;
}

static long Factorial(int number)
{
    long result = 1;
    for (int i = 2; i < number; i++)
    {
        result *= i;
    }
    return result;
}
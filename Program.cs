using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Debug vs. Release");

        // Проверка метода Add
        Console.WriteLine(\$"Add(2, 3) = {Add(2, 3)}");

        // Проверка метода SumTo с замером времени
        int n = 1_000_000_000;
        
        var stopwatch = Stopwatch.StartNew();
        long result = SumTo(n);
        stopwatch.Stop();

        Console.WriteLine(\$"SumTo({n}) = {result}");
        Console.WriteLine(\$"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
    }

    static int Add(int a, int b)
    {
        int result = a + b;
        return result;
    }

    static long SumTo(int n)
    {
        long sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }
}

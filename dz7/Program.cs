namespace dz7;
using System.Diagnostics;
class Program
{
    static void Main()
    {
        var watch = new Stopwatch();
        watch.Start();
        var cycleResult = Cycle(6);
        watch.Stop();
        Console.WriteLine(String.Format("Результат {0}. Время работы {1}", cycleResult, watch.ElapsedTicks));
        watch.Restart();
        var recursiveResult = Recursive(6);
        watch.Stop();
        Console.WriteLine(String.Format("Результат {0}. Время работы {1}", recursiveResult, watch.ElapsedTicks));
    }
    static long Recursive(int n)
    {
        if (n < 2)
            return n;
        return Recursive(n - 1) + Recursive(n - 2);
    }
    static long Cycle(int n)
    {
        if (n < 2)
            return n;
        var a = new long[] { 0, 1 };
        for (int i = 2; i <= n; i++)
            (a[0], a[1]) = (a[1], a[0] + a[1]);
        return a[1];
    }
}

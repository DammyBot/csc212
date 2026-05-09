using System;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        // Console.WriteLine("Hello Sandbox World!");

        // var numbers = new List<int> { 1, 2, 3, 4 };
        // numbers.Add(5);
        // for(var i = 0; i<numbers.Count; i++)
        // {
        //     Console.WriteLine(numbers[i]);
        // }

        Run();
    }

    public void Run()
    {
        var executionTime = Time(() => LotsOfLoops(100), 10);
        Console.WriteLine($"Execution Time: {executionTime} ms");
    }

    private void LotsOfLoops(int n)
    {
        int total = 0;
        for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    {
                        for (int k = 0; k < n; k++)
                        {
                            total += (i*j*k);
                        }
                    }
            }

        Console.WriteLine(total);
    }

    private double Time(Action executeAlgorithm, int times)
        {
            var sw = Stopwatch.StartNew();
            for (var i = 0; i < times; ++i)
                {
                    executeAlgorithm(); // Calls the action passed in to this method
                }

            sw.Stop();
            return sw.Elapsed.TotalMilliseconds / times;
        }
}
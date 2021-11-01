using System;

namespace AppNet5
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine($"App: AppNet5, calling: {new net5.Class().Say()}");
            Console.WriteLine($"App: AppNet5, calling: {new netcoreapp31.Class().Say()}");
            Console.WriteLine($"App: AppNet5, calling: {new netstandard21.Class().Say()}");
            Console.WriteLine($"App: AppNet5, calling: {new netstandard20.Class().Say()}");

            Console.WriteLine($"App: AppNet5, calling: {new net48.Class().Say()}");
            Console.WriteLine($"App: AppNet5, calling: {new net461.Class().Say()}");
            Console.WriteLine($"App: AppNet5, calling: {new net45.Class().Say()}");
            Console.WriteLine($"App: AppNet5, calling: {new net4.Class().Say()}");

        }
    }
}

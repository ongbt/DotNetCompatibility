using System;

namespace AppNetCore31
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine($"App: AppNetCore31, calling: {new net5.Class().Say()}"); // [compile-ide] CS1705-5.0.0.0
            Console.WriteLine($"App: AppNetCore31, calling: {new netcoreapp31.Class().Say()}");
            Console.WriteLine($"App: AppNetCore31, calling: {new netstandard21.Class().Say()}");
            Console.WriteLine($"App: AppNetCore31, calling: {new netstandard20.Class().Say()}");

            Console.WriteLine($"App: AppNetCore31, calling: {new net48.Class().Say()}");
            Console.WriteLine($"App: AppNetCore31, calling: {new net461.Class().Say()}");
            Console.WriteLine($"App: AppNetCore31, calling: {new net45.Class().Say()}");
            Console.WriteLine($"App: AppNetCore31, calling: {new net4.Class().Say()}");


        }
    }
}

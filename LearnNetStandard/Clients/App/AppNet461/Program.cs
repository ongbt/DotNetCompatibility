using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet461
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine($"App: AppNet461, calling: {new net5.Class().Say()}");
            // Console.WriteLine($"App: AppNet461, calling: {new netcoreapp31.Class().Say()}");
            // Console.WriteLine($"App: AppNet461, calling: {new netstandard21.Class().Say()}");
            Console.WriteLine($"App: AppNet461, calling: {new netstandard20.Class().Say()}");
            // Console.WriteLine($"App: AppNet461, calling: {new net48.Class().Say()}");
            Console.WriteLine($"App: AppNet461, calling: {new net461.Class().Say()}");
            Console.WriteLine($"App: AppNet461, calling: {new net45.Class().Say()}");
            Console.WriteLine($"App: AppNet461, calling: {new net4.Class().Say()}");
            Console.Read();

        }
    }
}

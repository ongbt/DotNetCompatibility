using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet45
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine($"App: AppNet45, calling: {new net5.Class().Say()}");
            // Console.WriteLine($"App: AppNet45, calling: {new netcoreapp31.Class().Say()}");
            // Console.WriteLine($"App: AppNet45, calling: {new netstandard21.Class().Say()}"); // [compile-ide] CS0012-2.1.0.0
            // Console.WriteLine($"App: AppNet45, calling: {new netstandard20.Class().Say()}"); // [compile-ide] CS0012-2.0.0.0
            // Console.WriteLine($"App: AppNet45, calling: {new net48.Class().Say()}"); // [compile-build] CS0246-net48
            // Console.WriteLine($"App: AppNet45, calling: {new net461.Class().Say()}"); // [compile-build] CS0246-net461
            Console.WriteLine($"App: AppNet45, calling: {new net45.Class().Say()}");
            Console.WriteLine($"App: AppNet45, calling: {new net4.Class().Say()}");
            Console.Read();
        }
    }
}

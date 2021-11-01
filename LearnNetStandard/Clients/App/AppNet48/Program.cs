using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AppNet48
{
    // This project is special as it does not (and cannot) reference the netstandard2.1 lib.
    // If it does it will get an error even when using classes from a netstandard2.0 lib (strange..)
    class Program 
    { 
        static void Main(string[] args)
        {
            Console.WriteLine(  MethodBase.GetCurrentMethod().DeclaringType.Name);
              // Console.WriteLine($"App: AppNet48, calling: {new net5.Class().Say()}");
              //Console.WriteLine($"App: AppNet48, calling: {new netcoreapp31.Class().Say()}");
            // Console.WriteLine($"App: AppNet48, calling: {new netstandard21.Class().Say()}");
            Console.WriteLine($"App: AppNet48, calling: {new netstandard20.Class().Say()}");
            Console.WriteLine($"App: AppNet48, calling: {new net48.Class().Say()}");
            Console.WriteLine($"App: AppNet48, calling: {new net461.Class().Say()}");
            Console.WriteLine($"App: AppNet48, calling: {new net45.Class().Say()}");
            Console.WriteLine($"App: AppNet48, calling: {new net4.Class().Say()}");
            Console.Read();
        }
    }
}

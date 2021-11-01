using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net461
{
    public class Class
    {
        public string Say()
        {
            string className = this.GetType().Assembly.FullName;
            Console.WriteLine(" I am: " + className);
            Console.WriteLine(" I called:\n" + CallTell());
            return className;
        }
        public string CallTell()
        {
            string result = $" Library: {new lowerNet4.Class().Tell()}\n";
            result += $" Library: {new lowerNet45.Class().Tell()}\n";
            result += $" Library: {new lowerNet461.Class().Tell()}\n";
            // result += $" Library: {new lowerNet48.Class().Tell()}\n"; // CS0246: The type or namespace name 'lowerNet461' could not be found (are you missing a using directive or an assembly reference?)
            result += $" Library: {new lowerNetstandard20.Class().Tell()}\n";  
            // result += $" Library: {new lowerNetstandard21.Class().Tell()}\n"; // [runtime] System.IO.FileNotFoundException: Could not load file or assembly 'netstandard, Version=2.1.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51' or one of its dependencies. The system cannot find the file specified.
            //                             must also remove the lowerNetstandard21 DLL from reference, or runtime error will persist

            return result;
        }
    }
}


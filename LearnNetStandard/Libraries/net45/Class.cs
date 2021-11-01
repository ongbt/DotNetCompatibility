using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net45
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
            // result += $" Library: {new lowerNet461.Class().Tell()}\n"; // CS0246: The type or namespace name 'lowerNet461' could not be found (are you missing a using directive or an assembly reference?)
            return result;
        }
    }
}



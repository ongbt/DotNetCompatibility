using System;

namespace netcoreapp21
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
            result += $" Library: {new lowerNet48.Class().Tell()}\n";
            result += $" Library: {new lowerNetstandard20.Class().Tell()}\n";
            // result += $" Library: {new lowerNetstandard21.Class().Tell()}\n"; // Could not load file or assembly 'netstandard, Version=2.1.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'. The system cannot find the file specified.
            result += $" Library: {new lowerNetcoreapp21.Class().Tell()}\n";
            //   result += $" Library: {new lowerNetcoreapp31.Class().Tell()}\n"; // CS1705	Assembly 'lowerNetcoreapp31' with identity 'lowerNetcoreapp31, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null' uses 'System.Runtime, Version=4.2.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' which has a higher version than referenced assembly 'System.Runtime' with identity 'System.Runtime, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'	
            //   result += $" Library: {new net5.Class().Tell()}\n"; // CS0246: The type or namespace name 'net5' could not be found (are you missing a using directive or an assembly reference?)

            return result;
        }
    }
}

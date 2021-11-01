using System;
using System.IO;
using System.Reflection;

namespace net5
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
            result += $" Library: {new lowerNetstandard21.Class().Tell()}\n";
            result += $" Library: {new lowerNetcoreapp21.Class().Tell()}\n";
            result += $" Library: {new lowerNetcoreapp31.Class().Tell()}\n";
            result += $" Library: {new lowerNet5.Class().Tell()}\n"; 
            return result;
        }
    }
}



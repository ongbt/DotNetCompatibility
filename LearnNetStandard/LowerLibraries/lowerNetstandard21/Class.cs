using System;

namespace lowerNetstandard21
{
    public class Class
    {
        public string Tell()
        {
            string className = this.GetType().Assembly.FullName;
            Console.WriteLine("  I am: " + className);
            return className;
        }
    }
}


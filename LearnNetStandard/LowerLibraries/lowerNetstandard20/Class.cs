using System;

namespace lowerNetstandard20
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


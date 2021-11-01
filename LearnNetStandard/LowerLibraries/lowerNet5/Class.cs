using System;

namespace lowerNet5
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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lowerNet4
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


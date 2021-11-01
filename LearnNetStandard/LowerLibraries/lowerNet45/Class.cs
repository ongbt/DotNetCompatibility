using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lowerNet45
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



﻿using System;
using System.Reflection;

namespace netstandard20
{
    public class Class
    {
        public string Say()
        {
            string className = this.GetType().Assembly.FullName;
            Console.WriteLine("I am: " + className);
            return className;
        }
    }
}

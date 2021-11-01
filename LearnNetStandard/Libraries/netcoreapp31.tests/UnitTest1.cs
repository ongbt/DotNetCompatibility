using System;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace netcoreapp31.tests
{
    
    public class UnitTest1
    {
        [Fact]
        public void netcoreapp31()
        {
            string s = new netcoreapp31.Class().Say();
        }

        public UnitTest1(ITestOutputHelper output)
        {
            var converter = new Converter(output);
            Console.SetOut(converter);
        }
        private class Converter : TextWriter
        {
            ITestOutputHelper _output;
            public Converter(ITestOutputHelper output)
            {
                _output = output;
            }
            public override Encoding Encoding
            {
                get { return Encoding.UTF8; }
            }
            public override void WriteLine(string message)
            {
                _output.WriteLine(message);
            }
            public override void WriteLine(string format, params object[] args)
            {
                _output.WriteLine(format, args);
            }

            public override void Write(char value)
            {
                throw new NotSupportedException("This text writer only supports WriteLine(string) and WriteLine(string, params object[]).");
            }
        }
    }
    

}
using System;
using AssemblyBrowserLibrary;
using NUnit.Framework;

namespace AssemblyBrowserTests
{
    [TestFixture]
    public class Tests
    {
        private readonly AssemblyBrowser _assemblyBrowser = new AssemblyBrowser();
        private MyClass _myClass = new MyClass();

        [Test]
        public void Test1()
        {
            
        }
    }
    
    public class MyClass
    {
        public double MyDouble { get; set; }

        public int MyMethod(int param)
        {
            return param;
        }
    }
}
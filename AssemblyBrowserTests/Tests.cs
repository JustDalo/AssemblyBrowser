using System;
using AssemblyBrowserLibrary;
using AssemblyBrowserLibrary.AssemblyCompositionElements;
using NUnit.Framework;

namespace AssemblyBrowserTests
{
    [TestFixture]
    public class Tests
    {
        private readonly AssemblyBrowser _assemblyBrowser = new AssemblyBrowser();

        [Test]
        public void Test1()
        {
            AssemblyContainerInfo[] assembly = _assemblyBrowser.GetNamespace(@"C:\Users\ASUS\RiderProjects\MPPproject3\TestLibrary\bin\Debug\TestLibrary.dll");
            Assert.NotNull(assembly);
        }
    }
}
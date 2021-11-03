using System;
using AssemblyBrowserLibrary;
using AssemblyBrowserLibrary.AssemblyCompositionElements;
using NUnit.Framework;

namespace AssemblyBrowserTests
{
    [TestFixture]
    public class Tests
    {
        private AssemblyBrowser _assemblyBrowser;
        private AssemblyContainerInfo[] _assembly;

        [SetUp]
        public void setUp()
        {
            _assemblyBrowser = new AssemblyBrowser();
            _assembly = _assemblyBrowser.GetNamespace(
                @"C:\Users\ASUS\RiderProjects\MPPproject3\TestLibrary\bin\Debug\TestLibrary.dll");
        }
        [Test]
        public void CreateAssembly()
        {
            Assert.NotNull(_assembly);
        }

        [Test]
        public void GetAssemblyNamespace()
        {
            var namespaces  = _assembly[0].DeclarationName;
            Assert.That("TestLibrary", Is.EqualTo(namespaces));
        }

        [Test]
        public void GetAssemblyFirstType()
        {
            var firstType = _assembly[0].Members[0].DeclarationName;
            Assert.That("Class1", Is.EqualTo(firstType));
        }
        [Test]
        public void GetAssemblySecondType()
        {
            var secondType = _assembly[0].Members[1].DeclarationName;
            Assert.That("Class2", Is.EqualTo(secondType));
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AssemblyBrowserLibrary.AssemblyCompositionElements;

namespace AssemblyBrowserLibrary
{
    public class AssemblyBrowser
    {
        private readonly List<AssemblyMemberInfo> _extensionMethods = new List<AssemblyMemberInfo>(); 
        
        public AssemblyBrowser()
        {
            
        }

        public AssemblyContainerInfo[] GetNamespace(string path)
        {
            var assembly = Assembly.LoadFile(path);
            var types = assembly.GetTypes();
            var namespaces = new Dictionary<string, AssemblyContainerInfo>();
            foreach (var type in types)
            {
                var typeNamespace = type.Namespace;
                if (typeNamespace == null)
                {
                    continue;
                }

                AssemblyContainerInfo namespaceInfo = new AssemblyContainerInfo();
                namespaces.Add(typeNamespace, namespaceInfo);
            }
            AssemblyContainerInfo[] result = namespaces.Values.ToArray();
            return result;
        }
        private void AddExtensionMethod()
        {
            
        }
        
        
    }
}
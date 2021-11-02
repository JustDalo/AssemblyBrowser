using System.Collections.Generic;
using AssemblyBrowserLibrary.AssemblyCompositionElements;
using AssemblyBrowserLibrary.AssemblyCompositionElements.MemberTypes;

namespace AssemblyBrowser.TreeElems
{
    public class TreeNamespace : AssemblyBrowserViewModel
    {
        public TreeNamespace(AssemblyContainerInfo nameSpace)
        {
            NameSpaceName = nameSpace.DeclarationName;
            TreeTypes = new List<AssemblyMemberInfo>();
            foreach (AssemblyMemberInfo anotherType in nameSpace.Members)
            {
                //TreeTypes.Add(new AssemblyMemberInfo());
            }
        }  
        public List<AssemblyMemberInfo> TreeTypes { get; set; }
        public string NameSpaceName { get; set; }
    }
}
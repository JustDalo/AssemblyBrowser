using System.Collections.Generic;

namespace AssemblyBrowserLibrary.AssemblyCompositionElements
{
    public class AssemblyContainerInfo
    {
        public AssemblyContainerInfo()
        {
            Members = new List<AssemblyMemberInfo>();
        }
        public List<AssemblyMemberInfo> Members { get; set; }
        internal void AddMember(AssemblyMemberInfo member)
        {
            Members.Add(member);
        }
    }
}
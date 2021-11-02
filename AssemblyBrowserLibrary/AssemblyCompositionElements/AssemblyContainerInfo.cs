using System.Collections.Generic;

namespace AssemblyBrowserLibrary.AssemblyCompositionElements
{
    public abstract class AssemblyContainerInfo : AssemblyMemberInfo
    {
        public List<AssemblyMemberInfo> Members { get; set; }
        protected AssemblyContainerInfo()
        {
            Members = new List<AssemblyMemberInfo>();
        }
        
        internal void AddMember(AssemblyMemberInfo member)
        {
            Members.Add(member);
        }
    }
}
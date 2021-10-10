namespace AssemblyBrowserLibrary.AssemblyCompositionElements
{
    public class AssemblyMemberInfo
    {
        public AssemblyMemberType GetContainerType => AssemblyMemberType.Member;

        public string Name { get; set; }

        public string Modificators { get; set; }

        public string Type { get; set; }

        public string DeclarationName { get; set; }
    }
}
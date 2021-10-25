namespace AssemblyBrowserLibrary.AssemblyCompositionElements
{
    public abstract class AssemblyMemberInfo
    {
        public abstract AssemblyMemberType GetContainerType { get; set; }

        public string Name { get; set; }

        public string Modificators { get; set; }

        public string Type { get; set; }

        public string DeclarationName { get; set; }
        
    }
}
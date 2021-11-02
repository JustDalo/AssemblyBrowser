namespace AssemblyBrowserLibrary.AssemblyCompositionElements
{
    public abstract class AssemblyMemberInfo
    {
        public abstract AssemblyTypes GetContainerType { get; set; }
        public string DeclarationName { get; set; }
    }
}
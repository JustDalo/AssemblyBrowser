namespace AssemblyBrowserLibrary.AssemblyCompositionElements.MemberTypes
{
    public class AssemblyNamespaceType : AssemblyContainerInfo
    {
        public override AssemblyTypes GetContainerType
        {
            get => AssemblyTypes.Namespace;
            set => throw new System.NotImplementedException();
        }
    }
}
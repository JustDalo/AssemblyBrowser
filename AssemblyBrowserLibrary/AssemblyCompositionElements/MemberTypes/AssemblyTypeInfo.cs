namespace AssemblyBrowserLibrary.AssemblyCompositionElements.MemberTypes
{
    public class AssemblyTypeInfo : AssemblyContainerInfo
    {
        public override AssemblyTypes GetContainerType
        {
            get => AssemblyTypes.Type;
            set => throw new System.NotImplementedException();
        }
    }
}
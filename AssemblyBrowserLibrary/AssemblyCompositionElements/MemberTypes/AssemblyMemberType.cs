namespace AssemblyBrowserLibrary.AssemblyCompositionElements.MemberTypes
{
    public class AssemblyMember : AssemblyContainerInfo
    {
        public override AssemblyTypes GetContainerType
        {
            get => AssemblyTypes.Member;
            set => throw new System.NotImplementedException();
        }
    }
}
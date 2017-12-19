namespace DevOps.Primitives.NuGet
{
    public class NuGetReference
    {
        public NuGetReference() { }
        public NuGetReference(string include, string version, ReferenceType referenceType = ReferenceType.PackageReference)
        {
            Include = include;
            ReferenceType = referenceType;
            Version = version;
        }

        public string Include { get; set; }
        public ReferenceType ReferenceType { get; set; }
        public string Version { get; set; }
    }
}

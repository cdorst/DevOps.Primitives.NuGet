namespace DevOps.Primitives.NuGet
{
    public class NuGetReference
    {
        public NuGetReference() { }
        public NuGetReference(string include, string version)
        {
            Include = include;
            Version = version;
        }

        public string Include { get; set; }
        public string Version { get; set; }
    }
}

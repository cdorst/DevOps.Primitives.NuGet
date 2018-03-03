using DevOps.Primitives.Strings;
using ProtoBuf;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevOps.Primitives.NuGet
{
    [ProtoContract]
    [Table("NuGetReferences", Schema = "CodeDeclarations")]
    public class NuGetReference
    {
        public NuGetReference() { }
        public NuGetReference(string include, string version)
        {
            Include = new AsciiStringReference(include);
            Version = new AsciiStringReference(version);
        }

        [ProtoMember(1)]
        public int NuGetReferenceId { get; set; }

        [ProtoMember(2)]
        public AsciiStringReference Include { get; set; }
        [ProtoMember(3)]
        public int IncludeId { get; set; }

        [ProtoMember(4)]
        public AsciiStringReference Version { get; set; }
        [ProtoMember(5)]
        public int VersionId { get; set; }
    }
}

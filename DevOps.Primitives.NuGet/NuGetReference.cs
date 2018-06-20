using Common.EntityFrameworkServices;
using DevOps.Primitives.Strings;
using ProtoBuf;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevOps.Primitives.NuGet
{
    [ProtoContract]
    [Table("NuGetReferences", Schema = "CodeDeclarations")]
    public class NuGetReference : IUniqueListRecord
    {
        public NuGetReference() { }
        public NuGetReference(in string include, in string version)
        {
            Include = new AsciiStringReference(in include);
            Version = new AsciiStringReference(in version);
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

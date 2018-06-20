using Common.EntityFrameworkServices;
using ProtoBuf;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevOps.Primitives.NuGet
{
    [ProtoContract]
    [Table("NuGetReferenceListAssociations", Schema = "CodeDeclarations")]
    public class NuGetReferenceListAssociation : IUniqueListAssociation<NuGetReference>
    {
        [ProtoMember(1)]
        public int NuGetReferenceListAssociationId { get; set; }

        [ProtoMember(2)]
        public NuGetReference NuGetReference { get; set; }
        [ProtoMember(3)]
        public int NuGetReferenceId { get; set; }

        [ProtoMember(4)]
        public NuGetReferenceList NuGetReferenceList { get; set; }
        [ProtoMember(5)]
        public int NuGetReferenceListId { get; set; }

        public NuGetReference GetRecord() => NuGetReference;

        public void SetRecord(in NuGetReference record)
        {
            NuGetReference = record;
            NuGetReferenceId = record.NuGetReferenceId;
        }
    }
}

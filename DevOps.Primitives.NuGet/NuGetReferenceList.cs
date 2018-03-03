using Common.EntityFrameworkServices;
using Common.EntityFrameworkServices.Factories;
using DevOps.Primitives.Strings;
using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevOps.Primitives.NuGet
{
    [ProtoContract]
    [Table("NuGetReferenceLists", Schema = "CodeDeclarations")]
    public class NuGetReferenceList : IUniqueList<NuGetReference, NuGetReferenceListAssociation>
    {
        [ProtoMember(1)]
        public int NuGetReferenceListId { get; set; }

        [ProtoMember(2)]
        public AsciiStringReference ListIdentifier { get; set; }
        [ProtoMember(3)]
        public int ListIdentifierId { get; set; }

        [ProtoMember(4)]
        public List<NuGetReferenceListAssociation> NuGetReferenceListAssociations { get; set; }

        public List<NuGetReferenceListAssociation> GetAssociations() => NuGetReferenceListAssociations;

        public void SetRecords(List<NuGetReference> records)
        {
            NuGetReferenceListAssociations = UniqueListAssociationsFactory<NuGetReference, NuGetReferenceListAssociation>.Create(records);
            ListIdentifier = new AsciiStringReference(
                UniqueListIdentifierFactory<NuGetReference>.Create(records, r => r.NuGetReferenceId));
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolvexWorkshopApi.Model.Entities;

namespace SolvexWorkshopApi.Model.EntityMapper
{
    public class WorkShopMemberMap : IEntityTypeConfiguration<WorkShopMember>
    {
        public void Configure(EntityTypeBuilder<WorkShopMember> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.MiddleName);
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.SecondLastName);
            builder.Property(x => x.DocumentType).IsRequired();
            builder.Property(x => x.DocumentTypeValue).IsRequired();
            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.Dob);

        }
    }
}

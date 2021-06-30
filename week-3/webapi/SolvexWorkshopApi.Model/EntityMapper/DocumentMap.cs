using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolvexWorkshopApi.Model.Entities;

namespace SolvexWorkshopApi.Model.EntityMapper
{
    public class DocumentMap : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.Property(x => x.FileName);
            builder.Property(x => x.OriginalName);
            builder.Property(x => x.ContentType);
        }
    }
}

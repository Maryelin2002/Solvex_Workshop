using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolvexWorkshopApi.Model.Entities;

namespace SolvexWorkshopApi.Model.EntityMapper
{
    public class WorkShopDayMap : IEntityTypeConfiguration<WorkShopDay>
    {
        public void Configure(EntityTypeBuilder<WorkShopDay> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Day).IsRequired();
            builder.Property(x => x.Mode).IsRequired();
            builder.Property(x => x.ModeLocation).IsRequired();
            builder.Property(x => x.StartHour).IsRequired();
            builder.Property(x => x.EndHour);
        }
    }
}
